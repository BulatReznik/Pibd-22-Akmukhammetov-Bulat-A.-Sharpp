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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeTruck.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 37);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1202, 843);
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
            this.label1.Location = new System.Drawing.Point(1240, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Парковки:";
            // 
            // listBoxParkingForTrucks
            // 
            this.listBoxParkingForTrucks.FormattingEnabled = true;
            this.listBoxParkingForTrucks.Location = new System.Drawing.Point(1210, 118);
            this.listBoxParkingForTrucks.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxParkingForTrucks.Name = "listBoxParkingForTrucks";
            this.listBoxParkingForTrucks.Size = new System.Drawing.Size(129, 108);
            this.listBoxParkingForTrucks.TabIndex = 14;
            this.listBoxParkingForTrucks.SelectedIndexChanged += new System.EventHandler(this.listBoxParkingForTrucks_SelectedIndexChanged);
            // 
            // buttonAddParkingForTrucks
            // 
            this.buttonAddParkingForTrucks.Location = new System.Drawing.Point(1209, 82);
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
            this.buttonDelParkingForTrucks.Location = new System.Drawing.Point(1209, 234);
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
            this.textBoxNewParkingForTrucks.Location = new System.Drawing.Point(1209, 54);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.toolStripMenuItem1.Text = "Сохранить название";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FormParkingForTrucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 836);
            this.Controls.Add(this.menuStrip);
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
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}