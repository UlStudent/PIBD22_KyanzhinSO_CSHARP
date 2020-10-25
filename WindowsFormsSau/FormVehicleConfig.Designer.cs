namespace WindowsFormsSau
{
    partial class FormVehicleConfig
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
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelArmorVehicle = new System.Windows.Forms.Label();
            this.labelSau = new System.Windows.Forms.Label();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.checkBoxMan = new System.Windows.Forms.CheckBox();
            this.checkBoxDopPushka = new System.Windows.Forms.CheckBox();
            this.checkBoxAntiRadar = new System.Windows.Forms.CheckBox();
            this.labelVehicleWeight = new System.Windows.Forms.Label();
            this.numericUpDownVehicleWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVehicleMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelVehicleMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxVehicle = new System.Windows.Forms.PictureBox();
            this.panelVehicle = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxType.SuspendLayout();
            this.groupBoxParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVehicleWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVehicleMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).BeginInit();
            this.panelVehicle.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelArmorVehicle);
            this.groupBoxType.Controls.Add(this.labelSau);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(133, 115);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип";
            // 
            // labelArmorVehicle
            // 
            this.labelArmorVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelArmorVehicle.Location = new System.Drawing.Point(19, 66);
            this.labelArmorVehicle.Name = "labelArmorVehicle";
            this.labelArmorVehicle.Size = new System.Drawing.Size(98, 30);
            this.labelArmorVehicle.TabIndex = 1;
            this.labelArmorVehicle.Text = "Бронированный автомобиль";
            this.labelArmorVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArmorVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelArmorVehicle_MouseDown);
            // 
            // labelSau
            // 
            this.labelSau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSau.Location = new System.Drawing.Point(19, 25);
            this.labelSau.Name = "labelSau";
            this.labelSau.Size = new System.Drawing.Size(98, 30);
            this.labelSau.TabIndex = 0;
            this.labelSau.Text = "Сау";
            this.labelSau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSau.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSau_MouseDown);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.checkBoxMan);
            this.groupBoxParams.Controls.Add(this.checkBoxDopPushka);
            this.groupBoxParams.Controls.Add(this.checkBoxAntiRadar);
            this.groupBoxParams.Controls.Add(this.labelVehicleWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownVehicleWeight);
            this.groupBoxParams.Controls.Add(this.numericUpDownVehicleMaxSpeed);
            this.groupBoxParams.Controls.Add(this.labelVehicleMaxSpeed);
            this.groupBoxParams.Location = new System.Drawing.Point(12, 133);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(277, 115);
            this.groupBoxParams.TabIndex = 2;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры";
            // 
            // checkBoxMan
            // 
            this.checkBoxMan.AutoSize = true;
            this.checkBoxMan.Location = new System.Drawing.Point(173, 86);
            this.checkBoxMan.Name = "checkBoxMan";
            this.checkBoxMan.Size = new System.Drawing.Size(70, 17);
            this.checkBoxMan.TabIndex = 6;
            this.checkBoxMan.Text = "Человек";
            this.checkBoxMan.UseVisualStyleBackColor = true;
            // 
            // checkBoxDopPushka
            // 
            this.checkBoxDopPushka.AutoSize = true;
            this.checkBoxDopPushka.Location = new System.Drawing.Point(173, 63);
            this.checkBoxDopPushka.Name = "checkBoxDopPushka";
            this.checkBoxDopPushka.Size = new System.Drawing.Size(81, 17);
            this.checkBoxDopPushka.TabIndex = 5;
            this.checkBoxDopPushka.Text = "Доп пушка";
            this.checkBoxDopPushka.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntiRadar
            // 
            this.checkBoxAntiRadar.AutoSize = true;
            this.checkBoxAntiRadar.Location = new System.Drawing.Point(173, 40);
            this.checkBoxAntiRadar.Name = "checkBoxAntiRadar";
            this.checkBoxAntiRadar.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAntiRadar.TabIndex = 4;
            this.checkBoxAntiRadar.Text = "Анти радар";
            this.checkBoxAntiRadar.UseVisualStyleBackColor = true;
            // 
            // labelVehicleWeight
            // 
            this.labelVehicleWeight.AutoSize = true;
            this.labelVehicleWeight.Location = new System.Drawing.Point(20, 70);
            this.labelVehicleWeight.Name = "labelVehicleWeight";
            this.labelVehicleWeight.Size = new System.Drawing.Size(55, 13);
            this.labelVehicleWeight.TabIndex = 3;
            this.labelVehicleWeight.Text = "Вес авто:";
            // 
            // numericUpDownVehicleWeight
            // 
            this.numericUpDownVehicleWeight.Location = new System.Drawing.Point(76, 86);
            this.numericUpDownVehicleWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVehicleWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVehicleWeight.Name = "numericUpDownVehicleWeight";
            this.numericUpDownVehicleWeight.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownVehicleWeight.TabIndex = 2;
            this.numericUpDownVehicleWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownVehicleMaxSpeed
            // 
            this.numericUpDownVehicleMaxSpeed.Location = new System.Drawing.Point(76, 46);
            this.numericUpDownVehicleMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVehicleMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVehicleMaxSpeed.Name = "numericUpDownVehicleMaxSpeed";
            this.numericUpDownVehicleMaxSpeed.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownVehicleMaxSpeed.TabIndex = 1;
            this.numericUpDownVehicleMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelVehicleMaxSpeed
            // 
            this.labelVehicleMaxSpeed.AutoSize = true;
            this.labelVehicleMaxSpeed.Location = new System.Drawing.Point(20, 29);
            this.labelVehicleMaxSpeed.Name = "labelVehicleMaxSpeed";
            this.labelVehicleMaxSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelVehicleMaxSpeed.TabIndex = 0;
            this.labelVehicleMaxSpeed.Text = "Макс скорость:";
            // 
            // pictureBoxVehicle
            // 
            this.pictureBoxVehicle.Location = new System.Drawing.Point(10, 9);
            this.pictureBoxVehicle.Name = "pictureBoxVehicle";
            this.pictureBoxVehicle.Size = new System.Drawing.Size(114, 99);
            this.pictureBoxVehicle.TabIndex = 3;
            this.pictureBoxVehicle.TabStop = false;
            // 
            // panelVehicle
            // 
            this.panelVehicle.AllowDrop = true;
            this.panelVehicle.Controls.Add(this.pictureBoxVehicle);
            this.panelVehicle.Location = new System.Drawing.Point(153, 13);
            this.panelVehicle.Name = "panelVehicle";
            this.panelVehicle.Size = new System.Drawing.Size(136, 114);
            this.panelVehicle.TabIndex = 4;
            this.panelVehicle.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelVehicle_DragDrop);
            this.panelVehicle.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelVehicle_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.label2);
            this.groupBoxColors.Controls.Add(this.label1);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(323, 25);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(179, 133);
            this.groupBoxColors.TabIndex = 5;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(95, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Доп. Цвет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Основной цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(133, 89);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(32, 29);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(95, 89);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(32, 29);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(57, 88);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(32, 29);
            this.panelOrange.TabIndex = 1;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(19, 88);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(32, 29);
            this.panelGray.TabIndex = 1;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(133, 54);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(32, 29);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(95, 54);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(32, 29);
            this.panelBlack.TabIndex = 1;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(57, 53);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(32, 29);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(19, 53);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(32, 29);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(432, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 27);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(432, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 24);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormVehicleConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 260);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelVehicle);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.groupBoxType);
            this.Name = "FormVehicleConfig";
            this.Text = "Выбор транспортно средства";
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVehicleWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVehicleMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVehicle)).EndInit();
            this.panelVehicle.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelArmorVehicle;
        private System.Windows.Forms.Label labelSau;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.CheckBox checkBoxAntiRadar;
        private System.Windows.Forms.Label labelVehicleWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownVehicleWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownVehicleMaxSpeed;
        private System.Windows.Forms.Label labelVehicleMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxMan;
        private System.Windows.Forms.CheckBox checkBoxDopPushka;
        private System.Windows.Forms.PictureBox pictureBoxVehicle;
        private System.Windows.Forms.Panel panelVehicle;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}