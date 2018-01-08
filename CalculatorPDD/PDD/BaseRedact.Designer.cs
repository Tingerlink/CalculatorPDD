namespace PDD
{
    partial class BaseRedact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseRedact));
            this.listSigns = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.listResolution = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsApply = new System.Windows.Forms.ToolStripButton();
            this.tsActSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAddSign = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteSing = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.cbResolution = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbType = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProhibishin = new System.Windows.Forms.ComboBox();
            this.btnDeleteProhibishin = new System.Windows.Forms.Button();
            this.btnAddProhibishin = new System.Windows.Forms.Button();
            this.listProhibishin = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteResolution = new System.Windows.Forms.Button();
            this.btnAddResolution = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listSigns
            // 
            this.listSigns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listSigns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSigns.FormattingEnabled = true;
            this.listSigns.Location = new System.Drawing.Point(0, 20);
            this.listSigns.Name = "listSigns";
            this.listSigns.Size = new System.Drawing.Size(393, 419);
            this.listSigns.TabIndex = 0;
            this.listSigns.SelectedValueChanged += new System.EventHandler(this.listSigns_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(58, 39);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(243, 48);
            this.tbDescription.TabIndex = 7;
            // 
            // listResolution
            // 
            this.listResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResolution.FormattingEnabled = true;
            this.listResolution.Location = new System.Drawing.Point(3, 50);
            this.listResolution.Name = "listResolution";
            this.listResolution.Size = new System.Drawing.Size(229, 277);
            this.listResolution.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsApply,
            this.tsActSettings,
            this.toolStripSeparator1,
            this.tsAddSign,
            this.tsDeleteSing,
            this.toolStripSeparator2,
            this.tsExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsApply
            // 
            this.tsApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsApply.Image = global::PDD.Properties.Resources.apply_9644;
            this.tsApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsApply.Name = "tsApply";
            this.tsApply.Size = new System.Drawing.Size(23, 22);
            this.tsApply.ToolTipText = "Применить изменения";
            this.tsApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tsActSettings
            // 
            this.tsActSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsActSettings.Image = global::PDD.Properties.Resources.applications_system_4236;
            this.tsActSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsActSettings.Name = "tsActSettings";
            this.tsActSettings.Size = new System.Drawing.Size(23, 22);
            this.tsActSettings.ToolTipText = "Редактор действий";
            this.tsActSettings.Click += new System.EventHandler(this.tsActSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAddSign
            // 
            this.tsAddSign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddSign.Image = global::PDD.Properties.Resources.add;
            this.tsAddSign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddSign.Name = "tsAddSign";
            this.tsAddSign.Size = new System.Drawing.Size(23, 22);
            this.tsAddSign.ToolTipText = "Добавить знак";
            this.tsAddSign.Click += new System.EventHandler(this.tsAddSign_Click);
            // 
            // tsDeleteSing
            // 
            this.tsDeleteSing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteSing.Image = global::PDD.Properties.Resources.delete;
            this.tsDeleteSing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteSing.Name = "tsDeleteSing";
            this.tsDeleteSing.Size = new System.Drawing.Size(23, 22);
            this.tsDeleteSing.ToolTipText = "Удалить выделенный знак";
            this.tsDeleteSing.Click += new System.EventHandler(this.tsDeleteSing_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsExit
            // 
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsExit.Image = global::PDD.Properties.Resources.application_exit_8626;
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(23, 22);
            this.tsExit.ToolTipText = "Закрыть редактор";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // cbResolution
            // 
            this.cbResolution.FormattingEnabled = true;
            this.cbResolution.Location = new System.Drawing.Point(3, 24);
            this.cbResolution.Name = "cbResolution";
            this.cbResolution.Size = new System.Drawing.Size(170, 21);
            this.cbResolution.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listSigns);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 441);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 20);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дорожные знаки";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbType);
            this.panel3.Controls.Add(this.pbImage);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnApply);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbDescription);
            this.panel3.Location = new System.Drawing.Point(408, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 441);
            this.panel3.TabIndex = 20;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(307, 41);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(179, 20);
            this.tbType.TabIndex = 25;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(4, 39);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(48, 48);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 24;
            this.pbImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Знак";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(411, 64);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 22;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Тип знака";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.cbProhibishin);
            this.panel7.Controls.Add(this.btnDeleteProhibishin);
            this.panel7.Controls.Add(this.btnAddProhibishin);
            this.panel7.Controls.Add(this.listProhibishin);
            this.panel7.Location = new System.Drawing.Point(245, 98);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(241, 338);
            this.panel7.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaGreen;
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(239, 20);
            this.panel8.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Запрещено";
            // 
            // cbProhibishin
            // 
            this.cbProhibishin.FormattingEnabled = true;
            this.cbProhibishin.Location = new System.Drawing.Point(3, 24);
            this.cbProhibishin.Name = "cbProhibishin";
            this.cbProhibishin.Size = new System.Drawing.Size(173, 21);
            this.cbProhibishin.TabIndex = 16;
            // 
            // btnDeleteProhibishin
            // 
            this.btnDeleteProhibishin.BackgroundImage = global::PDD.Properties.Resources.delete;
            this.btnDeleteProhibishin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProhibishin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProhibishin.Location = new System.Drawing.Point(212, 23);
            this.btnDeleteProhibishin.Name = "btnDeleteProhibishin";
            this.btnDeleteProhibishin.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteProhibishin.TabIndex = 17;
            this.btnDeleteProhibishin.UseVisualStyleBackColor = true;
            this.btnDeleteProhibishin.Click += new System.EventHandler(this.btnDeleteProhibishin_Click);
            // 
            // btnAddProhibishin
            // 
            this.btnAddProhibishin.BackgroundImage = global::PDD.Properties.Resources.add;
            this.btnAddProhibishin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProhibishin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProhibishin.Location = new System.Drawing.Point(182, 23);
            this.btnAddProhibishin.Name = "btnAddProhibishin";
            this.btnAddProhibishin.Size = new System.Drawing.Size(24, 24);
            this.btnAddProhibishin.TabIndex = 14;
            this.btnAddProhibishin.UseVisualStyleBackColor = true;
            this.btnAddProhibishin.Click += new System.EventHandler(this.btnAddProhibishin_Click);
            // 
            // listProhibishin
            // 
            this.listProhibishin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProhibishin.FormattingEnabled = true;
            this.listProhibishin.Location = new System.Drawing.Point(3, 50);
            this.listProhibishin.Name = "listProhibishin";
            this.listProhibishin.Size = new System.Drawing.Size(233, 277);
            this.listProhibishin.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.cbResolution);
            this.panel5.Controls.Add(this.btnDeleteResolution);
            this.panel5.Controls.Add(this.btnAddResolution);
            this.panel5.Controls.Add(this.listResolution);
            this.panel5.Location = new System.Drawing.Point(3, 98);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 338);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaGreen;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 20);
            this.panel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Разрешено";
            // 
            // btnDeleteResolution
            // 
            this.btnDeleteResolution.BackgroundImage = global::PDD.Properties.Resources.delete;
            this.btnDeleteResolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteResolution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteResolution.Location = new System.Drawing.Point(208, 23);
            this.btnDeleteResolution.Name = "btnDeleteResolution";
            this.btnDeleteResolution.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteResolution.TabIndex = 17;
            this.btnDeleteResolution.UseVisualStyleBackColor = true;
            this.btnDeleteResolution.Click += new System.EventHandler(this.btnDeleteResolution_Click);
            // 
            // btnAddResolution
            // 
            this.btnAddResolution.BackgroundImage = global::PDD.Properties.Resources.add;
            this.btnAddResolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddResolution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddResolution.Location = new System.Drawing.Point(179, 23);
            this.btnAddResolution.Name = "btnAddResolution";
            this.btnAddResolution.Size = new System.Drawing.Size(24, 24);
            this.btnAddResolution.TabIndex = 14;
            this.btnAddResolution.UseVisualStyleBackColor = true;
            this.btnAddResolution.Click += new System.EventHandler(this.btnAddResolution_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 20);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Редактирование";
            // 
            // BaseRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 300);
            this.Name = "BaseRedact";
            this.Text = "Редактирование базы";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSigns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ListBox listResolution;
        private System.Windows.Forms.Button btnAddResolution;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsApply;
        private System.Windows.Forms.ToolStripButton tsExit;
        private System.Windows.Forms.ComboBox cbResolution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProhibishin;
        private System.Windows.Forms.Button btnDeleteProhibishin;
        private System.Windows.Forms.Button btnAddProhibishin;
        private System.Windows.Forms.ListBox listProhibishin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteResolution;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.ToolStripButton tsActSettings;
        private System.Windows.Forms.ToolStripButton tsAddSign;
        private System.Windows.Forms.ToolStripButton tsDeleteSing;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}