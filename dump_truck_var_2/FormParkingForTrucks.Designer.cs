namespace dump_truck_var_2
{
    partial class FormParkingForTrucks
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeTruck = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxParkingForTrucks = new System.Windows.Forms.ListBox();
            this.buttonAddParkingForTrucks = new System.Windows.Forms.Button();
            this.buttonDelParkingForTrucks = new System.Windows.Forms.Button();
            this.textBoxNewParkingForTrucks = new System.Windows.Forms.TextBox();
            this.buttonAddTruckCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeTruck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1203, 880);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTakeTruck
            // 
            this.groupBoxTakeTruck.Controls.Add(this.buttonTake);
            this.groupBoxTakeTruck.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeTruck.Controls.Add(this.labelPlace);
            this.groupBoxTakeTruck.Location = new System.Drawing.Point(1209, 569);
            this.groupBoxTakeTruck.Name = "groupBoxTakeTruck";
            this.groupBoxTakeTruck.Size = new System.Drawing.Size(129, 110);
            this.groupBoxTakeTruck.TabIndex = 4;
            this.groupBoxTakeTruck.TabStop = false;
            this.groupBoxTakeTruck.Text = "Забрать грузовик";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(34, 72);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(75, 23);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(64, 37);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(59, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(16, 40);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Парковки:";
            // 
            // listBoxParkingForTrucks
            // 
            this.listBoxParkingForTrucks.FormattingEnabled = true;
            this.listBoxParkingForTrucks.Location = new System.Drawing.Point(1210, 99);
            this.listBoxParkingForTrucks.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParkingForTrucks.Name = "listBoxParkingForTrucks";
            this.listBoxParkingForTrucks.Size = new System.Drawing.Size(129, 108);
            this.listBoxParkingForTrucks.TabIndex = 14;
            this.listBoxParkingForTrucks.SelectedIndexChanged += new System.EventHandler(this.listBoxParkingForTrucks_SelectedIndexChanged);
            // 
            // buttonAddParkingForTrucks
            // 
            this.buttonAddParkingForTrucks.Location = new System.Drawing.Point(1209, 63);
            this.buttonAddParkingForTrucks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddParkingForTrucks.Name = "buttonAddParkingForTrucks";
            this.buttonAddParkingForTrucks.Size = new System.Drawing.Size(130, 28);
            this.buttonAddParkingForTrucks.TabIndex = 15;
            this.buttonAddParkingForTrucks.Text = "Добавить парковку";
            this.buttonAddParkingForTrucks.UseVisualStyleBackColor = true;
            this.buttonAddParkingForTrucks.Click += new System.EventHandler(this.buttonAddParkingForTrucks_Click);
            // 
            // buttonDelParkingForTrucks
            // 
            this.buttonDelParkingForTrucks.Location = new System.Drawing.Point(1209, 215);
            this.buttonDelParkingForTrucks.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelParkingForTrucks.Name = "buttonDelParkingForTrucks";
            this.buttonDelParkingForTrucks.Size = new System.Drawing.Size(130, 28);
            this.buttonDelParkingForTrucks.TabIndex = 16;
            this.buttonDelParkingForTrucks.Text = "Удалить парковку";
            this.buttonDelParkingForTrucks.UseVisualStyleBackColor = true;
            this.buttonDelParkingForTrucks.Click += new System.EventHandler(this.buttonDelParkingForTrucks_Click);
            // 
            // textBoxNewParkingForTrucks
            // 
            this.textBoxNewParkingForTrucks.Location = new System.Drawing.Point(1209, 37);
            this.textBoxNewParkingForTrucks.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewParkingForTrucks.Name = "textBoxNewParkingForTrucks";
            this.textBoxNewParkingForTrucks.Size = new System.Drawing.Size(130, 20);
            this.textBoxNewParkingForTrucks.TabIndex = 17;
            // 
            // buttonAddTruckCar
            // 
            this.buttonAddTruckCar.Location = new System.Drawing.Point(1209, 525);
            this.buttonAddTruckCar.Name = "buttonAddTruckCar";
            this.buttonAddTruckCar.Size = new System.Drawing.Size(130, 38);
            this.buttonAddTruckCar.TabIndex = 18;
            this.buttonAddTruckCar.Text = "Припарковать грузовик";
            this.buttonAddTruckCar.UseVisualStyleBackColor = true;
            this.buttonAddTruckCar.Click += new System.EventHandler(this.buttonAddTruckCar_Click);
            // 
            // FormParkingForTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 836);
            this.Controls.Add(this.buttonAddTruckCar);
            this.Controls.Add(this.textBoxNewParkingForTrucks);
            this.Controls.Add(this.buttonDelParkingForTrucks);
            this.Controls.Add(this.buttonAddParkingForTrucks);
            this.Controls.Add(this.listBoxParkingForTrucks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTakeTruck);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParkingForTrucks";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeTruck.ResumeLayout(false);
            this.groupBoxTakeTruck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakeTruck;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxParkingForTrucks;
        private System.Windows.Forms.Button buttonAddParkingForTrucks;
        private System.Windows.Forms.Button buttonDelParkingForTrucks;
        private System.Windows.Forms.TextBox textBoxNewParkingForTrucks;
        private System.Windows.Forms.Button buttonAddTruckCar;
    }
}