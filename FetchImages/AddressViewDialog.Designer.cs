namespace FetchImages
{
    partial class AddressViewDialog
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
            this.olvAddresses = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumnIndex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnUrl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.olvAddresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // olvAddresses
            // 
            this.olvAddresses.AllColumns.Add(this.olvColumnIndex);
            this.olvAddresses.AllColumns.Add(this.olvColumnUrl);
            this.olvAddresses.CellEditUseWholeCell = false;
            this.olvAddresses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnIndex,
            this.olvColumnUrl});
            this.olvAddresses.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvAddresses.Dock = System.Windows.Forms.DockStyle.Top;
            this.olvAddresses.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.olvAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.olvAddresses.FullRowSelect = true;
            this.olvAddresses.HideSelection = false;
            this.olvAddresses.Location = new System.Drawing.Point(0, 0);
            this.olvAddresses.Name = "olvAddresses";
            this.olvAddresses.ShowGroups = false;
            this.olvAddresses.Size = new System.Drawing.Size(445, 197);
            this.olvAddresses.TabIndex = 2;
            this.olvAddresses.UseCompatibleStateImageBehavior = false;
            this.olvAddresses.View = System.Windows.Forms.View.Details;
            this.olvAddresses.VirtualMode = true;
            this.olvAddresses.SelectionChanged += new System.EventHandler(this.olvAddresses_SelectionChanged);
            // 
            // olvColumnIndex
            // 
            this.olvColumnIndex.MaximumWidth = 50;
            this.olvColumnIndex.MinimumWidth = 50;
            this.olvColumnIndex.Text = "Index";
            this.olvColumnIndex.Width = 50;
            // 
            // olvColumnUrl
            // 
            this.olvColumnUrl.AspectName = "";
            this.olvColumnUrl.FillsFreeSpace = true;
            this.olvColumnUrl.Text = "URL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AddressViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.olvAddresses);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(80)))), ((int)(((byte)(102)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddressViewDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddressViewDialog";
            ((System.ComponentModel.ISupportInitialize)(this.olvAddresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.FastObjectListView olvAddresses;
        private BrightIdeasSoftware.OLVColumn olvColumnUrl;
        private BrightIdeasSoftware.OLVColumn olvColumnIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}