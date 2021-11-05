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
    public partial class FormTruckCarConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        ITransport dumpcar = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event TruckCarDelegate eventAddTruckCar;
        public FormTruckCarConfig()
        {
            InitializeComponent();
            panelRed.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelNavy.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawTruckCar()
        {
            if (dumpcar != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTruckCar.Width, pictureBoxTruckCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                dumpcar.SetPosition(30, 30, pictureBoxTruckCar.Width, pictureBoxTruckCar.Height);
                dumpcar.DrawTransport(gr);
                pictureBoxTruckCar.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(TruckCarDelegate ev)
        {
            if (eventAddTruckCar == null)
            {
                eventAddTruckCar = new TruckCarDelegate(ev);
            }
            else
            {
                eventAddTruckCar += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_TruckCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelTruckCar.DoDragDrop(labelTruckCar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDumpCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelDumpCar.DoDragDrop(labelDumpCar.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTruckCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTruckCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный грузовик":
                    dumpcar = new TruckCar((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Самосвал":
                    dumpcar = new DumpCar((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxGlasses.Checked, checkBoxTipperBody.Checked);
                    break;
            }
            DrawTruckCar();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (dumpcar != null)
            {
                (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            dumpcar.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTruckCar();
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (dumpcar is DumpCar)
            {
                (dumpcar as DumpCar).SetDopColor((Color)e.Data.GetData(typeof(Color)));
            }
            DrawTruckCar();
        }
        private void buttonAddTruckCar_Click(object sender, EventArgs e)
        {
            eventAddTruckCar?.Invoke((Vehicle)dumpcar);
            Close();
        }
    }
}
