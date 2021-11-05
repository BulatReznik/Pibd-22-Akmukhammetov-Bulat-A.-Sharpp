namespace dump_truck_var_2
{
    partial class FormTruckCarConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPlaneType = new System.Windows.Forms.GroupBox();
            this.labelDumpCar = new System.Windows.Forms.Label();
            this.labelTruckCar = new System.Windows.Forms.Label();
            this.groupBoxTruckCarParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxTipperBody = new System.Windows.Forms.CheckBox();
            this.checkBoxGlasses = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelTruckCarWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.panelTruckCar = new System.Windows.Forms.Panel();
            this.pictureBoxTruckCar = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddTruckCar = new System.Windows.Forms.Button();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelNavy = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxPlaneType.SuspendLayout();
            this.groupBoxTruckCarParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelTruckCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruckCar)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPlaneType
            // 
            this.groupBoxPlaneType.Controls.Add(this.labelDumpCar);
            this.groupBoxPlaneType.Controls.Add(this.labelTruckCar);
            this.groupBoxPlaneType.Location = new System.Drawing.Point(18, 24);
            this.groupBoxPlaneType.Name = "groupBoxPlaneType";
            this.groupBoxPlaneType.Size = new System.Drawing.Size(108, 199);
            this.groupBoxPlaneType.TabIndex = 4;
            this.groupBoxPlaneType.TabStop = false;
            this.groupBoxPlaneType.Text = "Тип грузовика";
            // 
            // labelDumpCar
            // 
            this.labelDumpCar.AllowDrop = true;
            this.labelDumpCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDumpCar.Location = new System.Drawing.Point(15, 116);
            this.labelDumpCar.Name = "labelDumpCar";
            this.labelDumpCar.Size = new System.Drawing.Size(86, 37);
            this.labelDumpCar.TabIndex = 4;
            this.labelDumpCar.Text = "Самосвал";
            this.labelDumpCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDumpCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDumpCar_MouseDown);
            // 
            // labelTruckCar
            // 
            this.labelTruckCar.AllowDrop = true;
            this.labelTruckCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruckCar.Location = new System.Drawing.Point(15, 60);
            this.labelTruckCar.Name = "labelTruckCar";
            this.labelTruckCar.Size = new System.Drawing.Size(86, 37);
            this.labelTruckCar.TabIndex = 3;
            this.labelTruckCar.Text = "Обычный грузовик";
            this.labelTruckCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTruckCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_TruckCar_MouseDown);
            // 
            // groupBoxTruckCarParametrs
            // 
            this.groupBoxTruckCarParametrs.Controls.Add(this.checkBoxTipperBody);
            this.groupBoxTruckCarParametrs.Controls.Add(this.checkBoxGlasses);
            this.groupBoxTruckCarParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxTruckCarParametrs.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxTruckCarParametrs.Controls.Add(this.labelTruckCarWeight);
            this.groupBoxTruckCarParametrs.Controls.Add(this.labelMaxSpeed);
            this.groupBoxTruckCarParametrs.Location = new System.Drawing.Point(18, 229);
            this.groupBoxTruckCarParametrs.Name = "groupBoxTruckCarParametrs";
            this.groupBoxTruckCarParametrs.Size = new System.Drawing.Size(364, 117);
            this.groupBoxTruckCarParametrs.TabIndex = 6;
            this.groupBoxTruckCarParametrs.TabStop = false;
            this.groupBoxTruckCarParametrs.Text = "Параметры";
            // 
            // checkBoxTipperBody
            // 
            this.checkBoxTipperBody.AutoSize = true;
            this.checkBoxTipperBody.Location = new System.Drawing.Point(227, 81);
            this.checkBoxTipperBody.Name = "checkBoxTipperBody";
            this.checkBoxTipperBody.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTipperBody.TabIndex = 5;
            this.checkBoxTipperBody.Text = "Кузов";
            this.checkBoxTipperBody.UseVisualStyleBackColor = true;
            // 
            // checkBoxGlasses
            // 
            this.checkBoxGlasses.AutoSize = true;
            this.checkBoxGlasses.Location = new System.Drawing.Point(227, 32);
            this.checkBoxGlasses.Name = "checkBoxGlasses";
            this.checkBoxGlasses.Size = new System.Drawing.Size(62, 17);
            this.checkBoxGlasses.TabIndex = 2;
            this.checkBoxGlasses.Text = "Стекла";
            this.checkBoxGlasses.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 81);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 4;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelTruckCarWeight
            // 
            this.labelTruckCarWeight.AutoSize = true;
            this.labelTruckCarWeight.Location = new System.Drawing.Point(12, 65);
            this.labelTruckCarWeight.Name = "labelTruckCarWeight";
            this.labelTruckCarWeight.Size = new System.Drawing.Size(84, 13);
            this.labelTruckCarWeight.TabIndex = 3;
            this.labelTruckCarWeight.Text = "Вес грузовика:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(12, 16);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // panelTruckCar
            // 
            this.panelTruckCar.AllowDrop = true;
            this.panelTruckCar.Controls.Add(this.pictureBoxTruckCar);
            this.panelTruckCar.Location = new System.Drawing.Point(132, 33);
            this.panelTruckCar.Name = "panelTruckCar";
            this.panelTruckCar.Size = new System.Drawing.Size(250, 190);
            this.panelTruckCar.TabIndex = 7;
            this.panelTruckCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruckCar_DragDrop);
            this.panelTruckCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruckCar_DragEnter);
            // 
            // pictureBoxTruckCar
            // 
            this.pictureBoxTruckCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTruckCar.Name = "pictureBoxTruckCar";
            this.pictureBoxTruckCar.Size = new System.Drawing.Size(250, 190);
            this.pictureBoxTruckCar.TabIndex = 0;
            this.pictureBoxTruckCar.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.buttonCancel);
            this.groupBoxColors.Controls.Add(this.buttonAddTruckCar);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelNavy);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(388, 33);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(190, 190);
            this.groupBoxColors.TabIndex = 8;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(104, 147);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddTruckCar
            // 
            this.buttonAddTruckCar.Location = new System.Drawing.Point(17, 147);
            this.buttonAddTruckCar.Name = "buttonAddTruckCar";
            this.buttonAddTruckCar.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTruckCar.TabIndex = 19;
            this.buttonAddTruckCar.Text = "Добавить";
            this.buttonAddTruckCar.UseVisualStyleBackColor = true;
            this.buttonAddTruckCar.Click += new System.EventHandler(this.buttonAddTruckCar_Click);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(144, 106);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(35, 35);
            this.panelOrange.TabIndex = 16;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(144, 65);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(35, 35);
            this.panelWhite.TabIndex = 12;
            // 
            // panelNavy
            // 
            this.panelNavy.BackColor = System.Drawing.Color.Navy;
            this.panelNavy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavy.Location = new System.Drawing.Point(103, 106);
            this.panelNavy.Name = "panelNavy";
            this.panelNavy.Size = new System.Drawing.Size(35, 35);
            this.panelNavy.TabIndex = 17;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(103, 65);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(35, 35);
            this.panelGreen.TabIndex = 13;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(62, 106);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(35, 35);
            this.panelPink.TabIndex = 18;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(21, 106);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 15;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(62, 65);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 14;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(21, 65);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 11;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(98, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(86, 37);
            this.labelDopColor.TabIndex = 5;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 16);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(86, 37);
            this.labelMainColor.TabIndex = 4;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // FormTruckCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelTruckCar);
            this.Controls.Add(this.groupBoxTruckCarParametrs);
            this.Controls.Add(this.groupBoxPlaneType);
            this.Name = "FormTruckCarConfig";
            this.Text = "Выбор Грузовика";
            this.groupBoxPlaneType.ResumeLayout(false);
            this.groupBoxTruckCarParametrs.ResumeLayout(false);
            this.groupBoxTruckCarParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelTruckCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruckCar)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlaneType;
        private System.Windows.Forms.Label labelDumpCar;
        private System.Windows.Forms.Label labelTruckCar;
        private System.Windows.Forms.GroupBox groupBoxTruckCarParametrs;
        private System.Windows.Forms.CheckBox checkBoxTipperBody;
        private System.Windows.Forms.CheckBox checkBoxGlasses;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelTruckCarWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Panel panelTruckCar;
        private System.Windows.Forms.PictureBox pictureBoxTruckCar;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddTruckCar;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelNavy;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
    }
}