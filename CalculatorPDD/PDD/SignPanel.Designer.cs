namespace PDD
{
    partial class SignPanel
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelConteiner = new System.Windows.Forms.Panel();
            this.lbNumber = new System.Windows.Forms.Label();
            this.tnName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbSelected = new System.Windows.Forms.CheckBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panelConteiner.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConteiner
            // 
            this.panelConteiner.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConteiner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConteiner.Controls.Add(this.lbNumber);
            this.panelConteiner.Controls.Add(this.tnName);
            this.panelConteiner.Controls.Add(this.panel6);
            this.panelConteiner.Controls.Add(this.pbImage);
            this.panelConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteiner.Location = new System.Drawing.Point(0, 0);
            this.panelConteiner.Name = "panelConteiner";
            this.panelConteiner.Size = new System.Drawing.Size(254, 70);
            this.panelConteiner.TabIndex = 7;
            this.panelConteiner.Click += new System.EventHandler(this.panelConteiner_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNumber.Location = new System.Drawing.Point(99, 3);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(43, 13);
            this.lbNumber.TabIndex = 5;
            this.lbNumber.Text = "1.1.20";
            this.lbNumber.Click += new System.EventHandler(this.panelConteiner_Click);
            // 
            // tnName
            // 
            this.tnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tnName.Location = new System.Drawing.Point(102, 18);
            this.tnName.Multiline = true;
            this.tnName.Name = "tnName";
            this.tnName.ReadOnly = true;
            this.tnName.Size = new System.Drawing.Size(147, 47);
            this.tnName.TabIndex = 7;
            this.tnName.Text = "Железнодорожный переезд со шлагбаумом";
            this.tnName.Click += new System.EventHandler(this.panelConteiner_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel6.Controls.Add(this.cbSelected);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 68);
            this.panel6.TabIndex = 4;
            this.panel6.Click += new System.EventHandler(this.panelConteiner_Click);
            // 
            // cbSelected
            // 
            this.cbSelected.AutoSize = true;
            this.cbSelected.Location = new System.Drawing.Point(6, 28);
            this.cbSelected.Name = "cbSelected";
            this.cbSelected.Size = new System.Drawing.Size(15, 14);
            this.cbSelected.TabIndex = 3;
            this.cbSelected.UseVisualStyleBackColor = true;
            this.cbSelected.Click += new System.EventHandler(this.cbSelected_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::PDD.Properties.Resources._1_1;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(32, 3);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(64, 64);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.panelConteiner_Click);
            // 
            // SignPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelConteiner);
            this.Name = "SignPanel";
            this.Size = new System.Drawing.Size(254, 70);
            this.panelConteiner.ResumeLayout(false);
            this.panelConteiner.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConteiner;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox tnName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cbSelected;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
