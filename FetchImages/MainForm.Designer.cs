namespace FetchImages
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAnalizePage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImportUrl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowOptions = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.olvAddresses = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnUrl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAddresses = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblAddressesNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSendLetter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAddresses)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAnalizePage,
            this.toolStripSeparator1,
            this.btnImportUrl,
            this.toolStripSeparator2,
            this.btnExport,
            this.toolStripSeparator3,
            this.btnShowOptions,
            this.toolStripSeparator4,
            this.btnClear});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(542, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAnalizePage
            // 
            this.btnAnalizePage.Image = global::FetchImages.Properties.Resources.icons8_source_code_24px;
            this.btnAnalizePage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnalizePage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnalizePage.Name = "btnAnalizePage";
            this.btnAnalizePage.Size = new System.Drawing.Size(81, 29);
            this.btnAnalizePage.Text = "Анализ..";
            this.btnAnalizePage.Click += new System.EventHandler(this.btnAnalizePage_ClickAsync);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnImportUrl
            // 
            this.btnImportUrl.Image = global::FetchImages.Properties.Resources.icons8_rename_24px;
            this.btnImportUrl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImportUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportUrl.Name = "btnImportUrl";
            this.btnImportUrl.Size = new System.Drawing.Size(79, 29);
            this.btnImportUrl.Text = "Импорт";
            this.btnImportUrl.Click += new System.EventHandler(this.btnImportUrl_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::FetchImages.Properties.Resources.icons8_microsoft_excel_24px;
            this.btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 29);
            this.btnExport.Text = "Экспорт";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btnShowOptions
            // 
            this.btnShowOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowOptions.Image = global::FetchImages.Properties.Resources.icons8_settings_24px;
            this.btnShowOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShowOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowOptions.Name = "btnShowOptions";
            this.btnShowOptions.Size = new System.Drawing.Size(28, 29);
            this.btnShowOptions.Text = "Настройки";
            this.btnShowOptions.Click += new System.EventHandler(this.btnShowOptions_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::FetchImages.Properties.Resources.icons8_broom_24px;
            this.btnClear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(28, 29);
            this.btnClear.Text = "Очистить список";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // olvAddresses
            // 
            this.olvAddresses.AllColumns.Add(this.olvColumnUrl);
            this.olvAddresses.AllColumns.Add(this.olvColumnAddresses);
            this.olvAddresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvAddresses.CellEditUseWholeCell = false;
            this.olvAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnUrl,
            this.olvColumnAddresses});
            this.olvAddresses.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvAddresses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.olvAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.olvAddresses.FullRowSelect = true;
            this.olvAddresses.HideSelection = false;
            this.olvAddresses.Location = new System.Drawing.Point(0, 32);
            this.olvAddresses.Name = "olvAddresses";
            this.olvAddresses.ShowGroups = false;
            this.olvAddresses.Size = new System.Drawing.Size(613, 496);
            this.olvAddresses.TabIndex = 1;
            this.olvAddresses.UseCompatibleStateImageBehavior = false;
            this.olvAddresses.View = System.Windows.Forms.View.Details;
            this.olvAddresses.VirtualMode = true;
            this.olvAddresses.DoubleClick += new System.EventHandler(this.olvAddresses_DoubleClick);
            // 
            // olvColumnUrl
            // 
            this.olvColumnUrl.AspectName = "Url";
            this.olvColumnUrl.FillsFreeSpace = true;
            this.olvColumnUrl.Text = "URL";
            // 
            // olvColumnAddresses
            // 
            this.olvColumnAddresses.MaximumWidth = 50;
            this.olvColumnAddresses.MinimumWidth = 50;
            this.olvColumnAddresses.Text = "К-во";
            this.olvColumnAddresses.Width = 50;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lblAddressesNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(613, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // lblAddressesNumber
            // 
            this.lblAddressesNumber.Name = "lblAddressesNumber";
            this.lblAddressesNumber.Size = new System.Drawing.Size(43, 17);
            this.lblAddressesNumber.Text = "fghfgh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 32);
            this.panel1.TabIndex = 3;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(542, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(71, 32);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSendLetter,
            this.toolStripSeparator5,
            this.mnuCheckUpdates,
            this.mnuShowAbout});
            this.toolStripDropDownButton1.Image = global::FetchImages.Properties.Resources.icons8_info_24px;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 29);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // mnuSendLetter
            // 
            this.mnuSendLetter.Name = "mnuSendLetter";
            this.mnuSendLetter.Size = new System.Drawing.Size(204, 22);
            this.mnuSendLetter.Text = "Обратная связь";
            this.mnuSendLetter.Click += new System.EventHandler(this.mnuSendLetter_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // mnuCheckUpdates
            // 
            this.mnuCheckUpdates.Name = "mnuCheckUpdates";
            this.mnuCheckUpdates.Size = new System.Drawing.Size(204, 22);
            this.mnuCheckUpdates.Text = "Проверить обновления";
            this.mnuCheckUpdates.Click += new System.EventHandler(this.mnuCheckUpdates_Click);
            // 
            // mnuShowAbout
            // 
            this.mnuShowAbout.Name = "mnuShowAbout";
            this.mnuShowAbout.Size = new System.Drawing.Size(204, 22);
            this.mnuShowAbout.Text = "О программе";
            this.mnuShowAbout.Click += new System.EventHandler(this.mnuShowAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 550);
            this.Controls.Add(this.olvAddresses);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FetchImages";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvAddresses)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAnalizePage;
        private System.Windows.Forms.ToolStripButton btnImportUrl;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAddressesNumber;
        private BrightIdeasSoftware.OLVColumn olvColumnUrl;
        private BrightIdeasSoftware.OLVColumn olvColumnAddresses;
        private BrightIdeasSoftware.FastObjectListView olvAddresses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripButton btnShowOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuSendLetter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckUpdates;
        private System.Windows.Forms.ToolStripMenuItem mnuShowAbout;
    }
}

