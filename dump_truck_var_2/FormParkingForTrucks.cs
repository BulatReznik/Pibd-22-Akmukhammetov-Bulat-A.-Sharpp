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
    public partial class FormParkingForTrucks : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly ParkingForTrucks<TruckCar> parking;

        public FormParkingForTrucks()
        {
            InitializeComponent();
            parking = new ParkingForTrucks<TruckCar>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать Грузовик"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkingTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var truckcar = new TruckCar(100, 1000, dialog.Color);
                if ((parking + truckcar) > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать Самосвал"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParckingDumpCar_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var dumpcar = new DumpCar(100, 1000, dialog.Color, dialogDop.Color,
                   true, true);
                    if ((parking + dumpcar)>-1)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (car != null)
                {
                    FormDumpCar form = new FormDumpCar();
                    form.SetDumpCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
