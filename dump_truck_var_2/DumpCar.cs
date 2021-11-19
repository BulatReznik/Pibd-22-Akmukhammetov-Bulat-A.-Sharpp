using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace dump_truck_var_2
{
    public class DumpCar : TruckCar
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия стекол
        /// </summary>
        public bool Glasses { private set; get; }
        /// <summary>
        /// Признак наличия Кузова у грузовика
        /// </summary>
        public bool TipperBody { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самосвала</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="glasses">Признак наличия стекол</param>
        /// <param name="tipperBody">Признак наличия кузова</param>
        public DumpCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool glasses, bool tipperBody) : base(maxSpeed, weight, mainColor, 250, 180)
        {
            DopColor = dopColor;
            Glasses = glasses;
            TipperBody = tipperBody;
        }
        /// <summary>
        /// Отрисовка 
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            Pen pen = new Pen(Color.Black, 3);
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
        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}