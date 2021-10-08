namespace dump_truck_var_2
{
    partial class FormDumpCar
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCreateCar = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxDumpCar = new System.Windows.Forms.PictureBox();
            this.buttonCreateDumpCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDumpCar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateCar
            // 
            this.buttonCreateCar.Location = new System.Drawing.Point(1077, 794);
            this.buttonCreateCar.Name = "buttonCreateCar";
            this.buttonCreateCar.Size = new System.Drawing.Size(129, 36);
            this.buttonCreateCar.TabIndex = 1;
            this.buttonCreateCar.Text = "Создать Грузовик";
            this.buttonCreateCar.UseVisualStyleBackColor = true;
            this.buttonCreateCar.Click += new System.EventHandler(this.buttonCreateCarTruck_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::dump_truck_var_2.Properties.Resources._9aa4151972abf59344d01195bb967e;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1192, 758);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 7;
            this.buttonDown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::dump_truck_var_2.Properties.Resources.e97b5050a25455d87c59005fc706e2;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(1228, 758);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::dump_truck_var_2.Properties.Resources._3579924016d408fe7632fddc7a8145;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(1156, 758);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::dump_truck_var_2.Properties.Resources._58177b11779522994aa1ef144df9c3;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(1192, 722);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxDumpCar
            // 
            this.pictureBoxDumpCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDumpCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDumpCar.Name = "pictureBoxDumpCar";
            this.pictureBoxDumpCar.Size = new System.Drawing.Size(1350, 836);
            this.pictureBoxDumpCar.TabIndex = 0;
            this.pictureBoxDumpCar.TabStop = false;
            // 
            // buttonCreateDumpCar
            // 
            this.buttonCreateDumpCar.Location = new System.Drawing.Point(1212, 794);
            this.buttonCreateDumpCar.Name = "buttonCreateDumpCar";
            this.buttonCreateDumpCar.Size = new System.Drawing.Size(129, 36);
            this.buttonCreateDumpCar.TabIndex = 8;
            this.buttonCreateDumpCar.Text = "Создать Самосвал";
            this.buttonCreateDumpCar.UseVisualStyleBackColor = true;
            this.buttonCreateDumpCar.Click += new System.EventHandler(this.buttonCreateDumpCar_Click);
            // 
            // FormDumpCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 836);
            this.Controls.Add(this.buttonCreateDumpCar);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateCar);
            this.Controls.Add(this.pictureBoxDumpCar);
            this.Name = "FormDumpCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDumpCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDumpCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDumpCar;
        private System.Windows.Forms.Button buttonCreateCar;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateDumpCar;
    }
}

