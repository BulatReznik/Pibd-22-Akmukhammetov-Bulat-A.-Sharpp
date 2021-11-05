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
        private readonly ParkingForTrucksCollection parkingForTrucksCollection;

        public FormParkingForTrucks()
        {
            InitializeComponent();
            parkingForTrucksCollection = new ParkingForTrucksCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadParkingForTrucks()
        {
            int index = listBoxParkingForTrucks.SelectedIndex;
            listBoxParkingForTrucks.Items.Clear();
            for (int i = 0; i < parkingForTrucksCollection.Keys.Count; i++)
            {
                listBoxParkingForTrucks.Items.Add(parkingForTrucksCollection.Keys[i]);
            }
            if (listBoxParkingForTrucks.Items.Count > 0 && (index == -1 || index >= listBoxParkingForTrucks.Items.Count))
            {
                listBoxParkingForTrucks.SelectedIndex = 0;
            }
            else if (listBoxParkingForTrucks.Items.Count > 0 && index > -1 && index < listBoxParkingForTrucks.Items.Count)
            {
                listBoxParkingForTrucks.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxParkingForTrucks.SelectedIndex > -1)
            {
                parkingForTrucksCollection[listBoxParkingForTrucks.SelectedItem.ToString()].Draw(gr);
            }
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
                if ((parkingForTrucksCollection[listBoxParkingForTrucks.SelectedItem.ToString()] + truckcar) > -1)
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
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxParkingForTrucks.SelectedIndex > -1 && maskedTextBoxPlace.Text != "")
            {
                var dumpcar = parkingForTrucksCollection[listBoxParkingForTrucks.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (dumpcar != null)
                {
                    FormDumpCar form = new FormDumpCar();
                    form.SetDumpCar(dumpcar);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void listBoxParkingForTrucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Добавить парковку
        /// </summary>
        private void buttonAddParkingForTrucks_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewParkingForTrucks.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingForTrucksCollection.AddParkingForTrucks(textBoxNewParkingForTrucks.Text);
            ReloadParkingForTrucks();
        }
        /// <summary>
        /// Удалить парковку
        /// </summary>
        private void buttonDelParkingForTrucks_Click(object sender, EventArgs e)
        {
            if (listBoxParkingForTrucks.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxParkingForTrucks.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingForTrucksCollection.DelParkingForTrucks(listBoxParkingForTrucks.SelectedItem.ToString());
                    ReloadParkingForTrucks();
                }
                Draw();                                                             
            }
        }
        private void buttonAddTruckCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkingForTrucks.SelectedIndex > -1)
            {
                var formTruckCarConfig = new FormTruckCarConfig();
                formTruckCarConfig.AddEvent(AddTruckCar);
                formTruckCarConfig.Show();
            }
        }
        /// <summary>
        /// Метод добавления грузовика
        /// </summary>
        /// <param name="dumpcar"></param>
        private void AddTruckCar(Vehicle dumpcar)
        {
            if (dumpcar != null && listBoxParkingForTrucks.SelectedIndex > -1)
            {
                if ((parkingForTrucksCollection[listBoxParkingForTrucks.SelectedItem.ToString()]) + dumpcar > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Грузовик не удалось поставить");
                }
            }
        }
    }
}
