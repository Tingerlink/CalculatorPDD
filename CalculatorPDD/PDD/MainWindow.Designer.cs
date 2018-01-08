namespace PDD
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tabSingByType = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsUnselect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторБазыЗнаковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьРедакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClean = new System.Windows.Forms.ToolStripButton();
            this.tsUpdate = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flowListSelectedSign = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lbProhibition = new System.Windows.Forms.ListBox();
            this.lbResolution = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSingByType
            // 
            this.tabSingByType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSingByType.Location = new System.Drawing.Point(4, 24);
            this.tabSingByType.Margin = new System.Windows.Forms.Padding(0);
            this.tabSingByType.Name = "tabSingByType";
            this.tabSingByType.SelectedIndex = 0;
            this.tabSingByType.Size = new System.Drawing.Size(770, 463);
            this.tabSingByType.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.редакторБазыЗнаковToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUnselect,
            this.toolStripSeparator2,
            this.tsExit});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // tsUnselect
            // 
            this.tsUnselect.Image = global::PDD.Properties.Resources.unselect;
            this.tsUnselect.Name = "tsUnselect";
            this.tsUnselect.Size = new System.Drawing.Size(191, 22);
            this.tsUnselect.Text = "Отменить выделение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(191, 22);
            this.tsExit.Text = "Выход";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // редакторБазыЗнаковToolStripMenuItem
            // 
            this.редакторБазыЗнаковToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьРедакторToolStripMenuItem});
            this.редакторБазыЗнаковToolStripMenuItem.Name = "редакторБазыЗнаковToolStripMenuItem";
            this.редакторБазыЗнаковToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.редакторБазыЗнаковToolStripMenuItem.Text = "Редактор базы знаков";
            // 
            // открытьРедакторToolStripMenuItem
            // 
            this.открытьРедакторToolStripMenuItem.Image = global::PDD.Properties.Resources.settings;
            this.открытьРедакторToolStripMenuItem.Name = "открытьРедакторToolStripMenuItem";
            this.открытьРедакторToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.открытьРедакторToolStripMenuItem.Text = "Открыть редактор";
            this.открытьРедакторToolStripMenuItem.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.toolStripSeparator1,
            this.btnClean,
            this.tsUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1044, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = global::PDD.Properties.Resources.settings;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClean
            // 
            this.btnClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClean.Image = global::PDD.Properties.Resources.unselect;
            this.btnClean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(23, 22);
            this.btnClean.ToolTipText = "Отменить выделение";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // tsUpdate
            // 
            this.tsUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsUpdate.Image = global::PDD.Properties.Resources.update;
            this.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(23, 22);
            this.tsUpdate.ToolTipText = "Обновить";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Location = new System.Drawing.Point(8, 49);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Panel2MinSize = 180;
            this.splitContainer1.Size = new System.Drawing.Size(1028, 500);
            this.splitContainer1.SplitterDistance = 786;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.tabSingByType);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(778, 492);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SteelBlue;
            this.panel8.Controls.Add(this.label6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(776, 20);
            this.panel8.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Доступные знаки";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 492);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowListSelectedSign);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 205);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 20);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выбранные знаки";
            // 
            // flowListSelectedSign
            // 
            this.flowListSelectedSign.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowListSelectedSign.AutoScroll = true;
            this.flowListSelectedSign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowListSelectedSign.Location = new System.Drawing.Point(0, 19);
            this.flowListSelectedSign.Name = "flowListSelectedSign";
            this.flowListSelectedSign.Size = new System.Drawing.Size(228, 184);
            this.flowListSelectedSign.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(0, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 281);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 20);
            this.panel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Результат";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lbInfo);
            this.panel5.Controls.Add(this.lbProhibition);
            this.panel5.Controls.Add(this.lbResolution);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 20);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(4);
            this.panel5.Size = new System.Drawing.Size(231, 262);
            this.panel5.TabIndex = 7;
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(6, 193);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.ScrollAlwaysVisible = true;
            this.lbInfo.Size = new System.Drawing.Size(216, 56);
            this.lbInfo.TabIndex = 9;
            // 
            // lbProhibition
            // 
            this.lbProhibition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbProhibition.FormattingEnabled = true;
            this.lbProhibition.Location = new System.Drawing.Point(6, 105);
            this.lbProhibition.Name = "lbProhibition";
            this.lbProhibition.ScrollAlwaysVisible = true;
            this.lbProhibition.Size = new System.Drawing.Size(216, 69);
            this.lbProhibition.TabIndex = 8;
            // 
            // lbResolution
            // 
            this.lbResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResolution.FormattingEnabled = true;
            this.lbResolution.Location = new System.Drawing.Point(6, 19);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.ScrollAlwaysVisible = true;
            this.lbResolution.Size = new System.Drawing.Size(216, 69);
            this.lbResolution.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Запрещено";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дополнительная информация";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainWindow";
            this.Text = "Калькулятор знаков ПДД";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSingByType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClean;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem редакторБазыЗнаковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьРедакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsUnselect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.FlowLayoutPanel flowListSelectedSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbResolution;
        private System.Windows.Forms.ListBox lbProhibition;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.ToolStripButton tsUpdate;
    }
}

