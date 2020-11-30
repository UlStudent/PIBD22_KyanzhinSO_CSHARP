namespace WindowsFormsSau
{
    partial class FormSau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSau));
            this.pictureBoxSau = new System.Windows.Forms.PictureBox();
            this.buttonCreateBasSau = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCreateSau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSau)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSau
            // 
            this.pictureBoxSau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSau.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSau.Name = "pictureBoxSau";
            this.pictureBoxSau.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxSau.TabIndex = 0;
            this.pictureBoxSau.TabStop = false;
            // 
            // buttonCreateBasSau
            // 
            this.buttonCreateBasSau.Location = new System.Drawing.Point(28, 402);
            this.buttonCreateBasSau.Name = "buttonCreateBasSau";
            this.buttonCreateBasSau.Size = new System.Drawing.Size(98, 23);
            this.buttonCreateBasSau.TabIndex = 1;
            this.buttonCreateBasSau.Text = "Create Bas Sau";
            this.buttonCreateBasSau.UseVisualStyleBackColor = true;
            this.buttonCreateBasSau.Click += new System.EventHandler(this.buttonCreateBasSau_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(661, 300);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(45, 40);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(712, 339);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(45, 40);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(661, 385);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(45, 40);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(610, 339);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(45, 40);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateSau
            // 
            this.buttonCreateSau.Location = new System.Drawing.Point(132, 402);
            this.buttonCreateSau.Name = "buttonCreateSau";
            this.buttonCreateSau.Size = new System.Drawing.Size(87, 23);
            this.buttonCreateSau.TabIndex = 6;
            this.buttonCreateSau.Text = "Create Sau";
            this.buttonCreateSau.UseVisualStyleBackColor = true;
            this.buttonCreateSau.Click += new System.EventHandler(this.buttonCreateSau_Click);
            // 
            // FormSau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateSau);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateBasSau);
            this.Controls.Add(this.pictureBoxSau);
            this.Name = "FormSau";
            this.Text = "FormSau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSau;
        private System.Windows.Forms.Button buttonCreateBasSau;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCreateSau;
    }
}