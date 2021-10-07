using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dump_truck_var_2
{
    public class DumpCar
    {
        /// <summary>
        /// Левая координата отрисовки грузовика
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая координата отрисовки грузовика
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth = 884;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight = 461;
        /// <summary>
        /// Ширина отрисовки грузовика
        /// </summary>
        private readonly int carWidth = 215;
        /// <summary>
        /// Высота отрисовки грузовика
        /// </summary>
        private readonly int carHeight = 150;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес грузовика
        /// </summary> 
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool FrontSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        public bool SideSpoiler { private set; get; }
        /// <summary>
        /// Признак наличия стекол
        /// </summary>
        public bool Glasses { private set; get; }
        /// <summary>
        /// Признак наличия Кузова у грузовика
        /// </summary>
        public bool TipperBody { private set; get; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самосвала</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="glasses">Признак наличия стекол</param>
        /// <param name="tipperBody">Признак наличия кузова</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool glasses, bool tipperBody)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Glasses = glasses;
            TipperBody = tipperBody;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //кузов
            Brush brRed = new SolidBrush(MainColor);
            g.FillRectangle(brRed, _startPosX+125, _startPosY, 75, 75);
            g.DrawRectangle(pen, _startPosX + 125, _startPosY, 75, 75);
            g.FillRectangle(brRed, _startPosX, _startPosY+75, 200, 25);
            g.DrawRectangle(pen, _startPosX, _startPosY + 75, 200, 25);
            //колеса
            Brush brGray = new SolidBrush(Color.Gray);
            g.FillEllipse(brGray, _startPosX, _startPosY + 100, 50, 50);
            g.FillEllipse(brGray, _startPosX + 50, _startPosY + 100, 50, 50);
            g.FillEllipse(brGray, _startPosX + 150, _startPosY + 100, 50, 50);
            g.DrawEllipse(pen, _startPosX, _startPosY + 100, 50, 50);
            g.DrawEllipse(pen, _startPosX + 50, _startPosY + 100, 50, 50);
            g.DrawEllipse(pen, _startPosX + 150, _startPosY + 100, 50, 50);
            //стекла
            if (Glasses)
            {
                Brush brGlasses = new SolidBrush(Color.Blue);
                g.FillRectangle(brGlasses, _startPosX + 140, _startPosY + 12, 60, 50);
                g.DrawRectangle(pen, _startPosX + 140, _startPosY + 12, 60, 50);
            }
            //кузов самосвала
            if (TipperBody)
            {
                Pen blackPen = new Pen(Color.Black, 5);
                PointF point1 = new PointF(_startPosX-15, _startPosY+75);
                PointF point2 = new PointF(_startPosX, _startPosY);
                PointF point3 = new PointF(_startPosX + 85, _startPosY);
                PointF point4 = new PointF(_startPosX + 95, _startPosY -18);
                PointF point5 = new PointF(_startPosX + 120, _startPosY -18);
                PointF point6 = new PointF(_startPosX + 120, _startPosY);
                PointF point7 = new PointF(_startPosX + 107, _startPosY);
                PointF point8 = new PointF(_startPosX + 95, _startPosY+75);
                PointF[] curvePoints =
                {
                     point1,point2,point3,point4,point5,point6,point7,point8
                };
                g.DrawPolygon(blackPen, curvePoints);
                Brush brTipperBody = new SolidBrush(DopColor);
                g.FillPolygon(brTipperBody, curvePoints);
            }
        }
    }
}



