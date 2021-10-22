﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dump_truck_var_2
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ParkingForTrucks<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 240;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 180;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public ParkingForTrucks(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="dumpcar">Добавляемый автомобиль</param>
        /// <returns></returns>
        public static int operator +(ParkingForTrucks<T> p, T dumpcar)
        {
            {
                for (int i = 0; i < p._places.Length; i++)
                {
                    if (p._places[i] == null)
                    {
                        p._places[i] = dumpcar;
                        p._places[i].SetPosition(25 + i % 5 * p._placeSizeWidth, i / 5 * p._placeSizeHeight + 35,
                        p.pictureWidth, p.pictureHeight);
                        return i;
                    }
                }
                return -1;
            }
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param /// <returns></returns>
        public static T operator -(ParkingForTrucks<T> p, int index)
        {
            if (index < p._places.Length)
            {
                if (p._places[index] != null)
                {
                    T dumpcar = p._places[index];
                    p._places[index] = null;
                    return dumpcar;
                }
            }
            return null;

        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 20; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth + 5, j * _placeSizeHeight + 10,
                       i * _placeSizeWidth + _placeSizeWidth / 2 , j * _placeSizeHeight + 10);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 5, 10, i * _placeSizeWidth + 5,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight + 10);
            }
        }
    }
}
