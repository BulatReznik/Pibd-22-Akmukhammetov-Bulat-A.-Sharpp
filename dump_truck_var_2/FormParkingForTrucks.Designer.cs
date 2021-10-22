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
            this.buttonParkingTruck = new System.Windows.Forms.Button();
            this.buttonParckingDumpCar = new System.Windows.Forms.Button();
            this.groupBoxTakeTruck = new System.Windows.Forms.GroupBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.buttonTake = new System.Windows.Forms.Button();
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
            // buttonParkingTruck
            // 
            this.buttonParkingTruck.Location = new System.Drawing.Point(1209, 12);
            this.buttonParkingTruck.Name = "buttonParkingTruck";
            this.buttonParkingTruck.Size = new System.Drawing.Size(129, 36);
            this.buttonParkingTruck.TabIndex = 2;
            this.buttonParkingTruck.Text = "Припарковать Грузовик";
            this.buttonParkingTruck.UseVisualStyleBackColor = true;
            this.buttonParkingTruck.Click += new System.EventHandler(this.buttonParkingTruck_Click);
            // 
            // buttonParckingDumpCar
            // 
            this.buttonParckingDumpCar.Location = new System.Drawing.Point(1209, 54);
            this.buttonParckingDumpCar.Name = "buttonParckingDumpCar";
            this.buttonParckingDumpCar.Size = new System.Drawing.Size(129, 36);
            this.buttonParckingDumpCar.TabIndex = 3;
            this.buttonParckingDumpCar.Text = "Припарковать Самосвал";
            this.buttonParckingDumpCar.UseVisualStyleBackColor = true;
            this.buttonParckingDumpCar.Click += new System.EventHandler(this.buttonParckingDumpCar_Click);
            // 
            // groupBoxTakeTruck
            // 
            this.groupBoxTakeTruck.Controls.Add(this.buttonTake);
            this.groupBoxTakeTruck.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeTruck.Controls.Add(this.labelPlace);
            this.groupBoxTakeTruck.Location = new System.Drawing.Point(1209, 96);
            this.groupBoxTakeTruck.Name = "groupBoxTakeTruck";
            this.groupBoxTakeTruck.Size = new System.Drawing.Size(129, 110);
            this.groupBoxTakeTruck.TabIndex = 4;
            this.groupBoxTakeTruck.TabStop = false;
            this.groupBoxTakeTruck.Text = "Забрать грузовик";
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
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(64, 37);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(59, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
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
            // FormParkingForTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 836);
            this.Controls.Add(this.groupBoxTakeTruck);
            this.Controls.Add(this.buttonParckingDumpCar);
            this.Controls.Add(this.buttonParkingTruck);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParkingForTrucks";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeTruck.ResumeLayout(false);
            this.groupBoxTakeTruck.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkingTruck;
        private System.Windows.Forms.Button buttonParckingDumpCar;
        private System.Windows.Forms.GroupBox groupBoxTakeTruck;
        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
    }
}