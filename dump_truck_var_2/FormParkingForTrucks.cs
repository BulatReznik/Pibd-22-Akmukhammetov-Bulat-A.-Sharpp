using System;
using System.Drawing;
using System.Windows.Forms;
using NLog;

namespace dump_truck_var_2
{
    public partial class FormParkingForTrucks : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly ParkingForTrucksCollection parkingForTrucksCollection;

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;

        public FormParkingForTrucks()
        {
            InitializeComponent();
            parkingForTrucksCollection = new ParkingForTrucksCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                try
                {
                    var dumpcar = parkingForTrucksCollection[listBoxParkingForTrucks.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (dumpcar != null)
                    {
                        FormDumpCar form = new FormDumpCar();
                        form.SetDumpCar(dumpcar);
                        form.ShowDialog();
                        logger.Info($"Изъят грузовик {dumpcar} с места{ maskedTextBoxPlace.Text}");
                    }
                    Draw();
                }
                catch (ParkingForTrucksNotFoundException ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listBoxParkingForTrucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку{ listBoxParkingForTrucks.SelectedItem.ToString()}");
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
            logger.Info($"Добавили парковку {textBoxNewParkingForTrucks.Text}");
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
                    logger.Info($"Удалили парковку{ listBoxParkingForTrucks.SelectedItem.ToString()}");
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
                try
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
                catch (ParkingForTrucksOverflowException ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingForTrucksCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadParkingForTrucks();
                    Draw();
                }
                catch (FormatException ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingForTrucksOverflowException ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Переполнение при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingForTrucksCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingForTrucksCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadParkingForTrucks();
                    Draw();
                }
                catch (FormatException ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ParkingForTrucksOverflowException ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Переполнение при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
