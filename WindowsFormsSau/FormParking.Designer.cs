namespace WindowsFormsSau
{
    partial class FormParking
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
            this.buttonCreateSau = new System.Windows.Forms.Button();
            this.buttonCreateArmorVehicle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeVehicle = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(659, 450);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonCreateSau
            // 
            this.buttonCreateSau.Location = new System.Drawing.Point(681, 12);
            this.buttonCreateSau.Name = "buttonCreateSau";
            this.buttonCreateSau.Size = new System.Drawing.Size(97, 51);
            this.buttonCreateSau.TabIndex = 1;
            this.buttonCreateSau.Text = "Припарковать Sau";
            this.buttonCreateSau.UseVisualStyleBackColor = true;
            this.buttonCreateSau.Click += new System.EventHandler(this.buttonSetSau_Click);
            // 
            // buttonCreateArmorVehicle
            // 
            this.buttonCreateArmorVehicle.Location = new System.Drawing.Point(681, 78);
            this.buttonCreateArmorVehicle.Name = "buttonCreateArmorVehicle";
            this.buttonCreateArmorVehicle.Size = new System.Drawing.Size(97, 49);
            this.buttonCreateArmorVehicle.TabIndex = 2;
            this.buttonCreateArmorVehicle.Text = "Припарковать бронированную машину";
            this.buttonCreateArmorVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateArmorVehicle.Click += new System.EventHandler(this.buttonSetArmorVehicle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeVehicle);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Controls.Add(this.maskedTextBoxPosition);
            this.groupBox1.Location = new System.Drawing.Point(665, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать технику";
            // 
            // buttonTakeVehicle
            // 
            this.buttonTakeVehicle.Location = new System.Drawing.Point(27, 63);
            this.buttonTakeVehicle.Name = "buttonTakeVehicle";
            this.buttonTakeVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeVehicle.TabIndex = 2;
            this.buttonTakeVehicle.Text = "Забрать";
            this.buttonTakeVehicle.UseVisualStyleBackColor = true;
            this.buttonTakeVehicle.Click += new System.EventHandler(this.buttonTakeVehicle_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(13, 40);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(42, 13);
            this.labelPosition.TabIndex = 1;
            this.labelPosition.Text = "Место:";
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(85, 37);
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBoxPosition.TabIndex = 0;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreateArmorVehicle);
            this.Controls.Add(this.buttonCreateSau);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Военная база";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonCreateSau;
        private System.Windows.Forms.Button buttonCreateArmorVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeVehicle;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPosition;
    }
}