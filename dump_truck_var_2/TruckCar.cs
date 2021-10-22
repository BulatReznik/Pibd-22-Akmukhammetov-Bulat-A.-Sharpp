using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dump_truck_var_2
{
    public class TruckCar : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки грузовика
        /// </summary>
        private readonly int carWidth = 215;
        /// <summary>
        /// Высота отрисовки грузовика
        /// </summary>
        private readonly int carHeight = 150;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public TruckCar(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected TruckCar(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.carWidth = carWidth;
            this.carHeight = carHeight;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 80 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //кузов
            Brush brRed = new SolidBrush(MainColor);
            g.FillRectangle(brRed, _startPosX + 125, _startPosY, 75, 75);
            g.DrawRectangle(pen, _startPosX + 125, _startPosY, 75, 75);
            g.FillRectangle(brRed, _startPosX, _startPosY + 75, 200, 25);
            g.DrawRectangle(pen, _startPosX, _startPosY + 75, 200, 25);
            //колеса
            Brush brGray = new SolidBrush(Color.Gray);
            g.FillEllipse(brGray, _startPosX, _startPosY + 100, 50, 50);
            g.FillEllipse(brGray, _startPosX + 50, _startPosY + 100, 50, 50);
            g.FillEllipse(brGray, _startPosX + 150, _startPosY + 100, 50, 50);
            g.DrawEllipse(pen, _startPosX, _startPosY + 100, 50, 50);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY + 100, 50, 50);
            g.DrawEllipse(pen, _startPosX + 150, _startPosY + 100, 50, 50);
        }
    }
}