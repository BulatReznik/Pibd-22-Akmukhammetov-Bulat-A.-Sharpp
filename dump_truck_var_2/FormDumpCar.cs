using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dump_truck_var_2
{
    public partial class FormDumpCar : Form
    {
        private ITransport dumpcar;
        /// <summary>
        /// Конструктор
        /// </summary> 
        public FormDumpCar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки грузовика
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDumpCar.Width, pictureBoxDumpCar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            dumpcar.DrawTransport(gr);
            pictureBoxDumpCar.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать грузовик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateCarTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dumpcar = new TruckCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red);
            dumpcar.SetPosition(rnd.Next(30, 100), rnd.Next(30, 100), pictureBoxDumpCar.Width, pictureBoxDumpCar.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать самосвал"
        /// </summary>
        private void buttonCreateDumpCar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dumpcar = new DumpCar(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red, Color.Yellow, true, true);
            dumpcar.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxDumpCar.Width, pictureBoxDumpCar.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (dumpcar != null)
            {
                //получаем имя кнопки
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        dumpcar.MoveTransport(Direction.Up);
                        break;
                    case "buttonDown":
                        dumpcar.MoveTransport(Direction.Down);
                        break;
                    case "buttonLeft":
                        dumpcar.MoveTransport(Direction.Left);
                        break;
                    case "buttonRight":
                        dumpcar.MoveTransport(Direction.Right);
                        break;
                }
                Draw();
            }
            else 
            {
                MessageBox.Show("Создайте самосвал или грузовик!");
            }
        }
        private void FormDumpCar_Load(object sender, EventArgs e){}
        private void button1_Click(object sender, EventArgs e){}
        private void button3_Click(object sender, EventArgs e){}
        private void button5_Click(object sender, EventArgs e){}     
        private void button3_Click_1(object sender, EventArgs e){}
    }
}
