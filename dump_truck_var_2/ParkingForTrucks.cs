using System;
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
    class ParkingForTrucks<T> where T : class, ITransport
    {
        /// <summary> 
        /// Список объектов, которые храним 
        /// </summary> 
        private readonly List<T> _places;
        /// <summary> 
        /// Максимальное количество мест на парковке 
        /// </summary> 
        private readonly int _maxCount;
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
        /// Размер парковки (высота)
        /// </summary>
        private readonly int parkingWidth;
        /// <summary>
        /// Размер парковки (ширина)
        /// </summary>
        private readonly int parkingHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public ParkingForTrucks(int picWidth, int picHeight)
        {
            parkingWidth = picWidth / _placeSizeWidth;
            parkingHeight = picHeight / _placeSizeHeight;
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
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
            if (p._places.Count < p._maxCount)
            {
                p._places.Add(dumpcar);
                return p._places.Count - 1;
            }
            else
            {
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
            if (index > -1 && index < p._places.Count)
            {
                T bufTruckCar = p._places[index];
                p._places.RemoveAt(index);
                return bufTruckCar;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                _places[i].SetPosition(i % parkingWidth * _placeSizeWidth + 35, i / parkingWidth * _placeSizeHeight + 25 , pictureWidth, pictureHeight);
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
                       i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight + 10);
                }
                g.DrawLine(pen, i * _placeSizeWidth + 5, 10, i * _placeSizeWidth + 5,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight + 10);
            }
        }
    }
}

