
namespace FetchImages
{
    partial class FetchOptionsDialog
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
            if(disposing && (components != null))
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUseRegEx = new System.Windows.Forms.CheckBox();
            this._secondaryPanel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUseRequestDelay = new System.Windows.Forms.CheckBox();
            this.txtRequestDelay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUseHtmlSrcCode = new System.Windows.Forms.CheckBox();
            this.lblDefaultRegex = new System.Windows.Forms.Label();
            this.chkUseCustomRegexpPattern = new System.Windows.Forms.CheckBox();
            this.txtCustomRegexpPattern = new System.Windows.Forms.TextBox();
            this.chkUseEmbeddedStrategies = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this._secondaryPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 280);
            this.panel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkUseEmbeddedStrategies);
            this.groupBox1.Controls.Add(this.txtCustomRegexpPattern);
            this.groupBox1.Controls.Add(this.chkUseCustomRegexpPattern);
            this.groupBox1.Controls.Add(this.lblDefaultRegex);
            this.groupBox1.Controls.Add(this.chkUseHtmlSrcCode);
            this.groupBox1.Controls.Add(this.chkUseRegEx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 174);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки поиска";
            // 
            // chkUseRegEx
            // 
            this.chkUseRegEx.AutoSize = true;
            this.chkUseRegEx.Location = new System.Drawing.Point(6, 47);
            this.chkUseRegEx.Name = "chkUseRegEx";
            this.chkUseRegEx.Size = new System.Drawing.Size(138, 19);
            this.chkUseRegEx.TabIndex = 20;
            this.chkUseRegEx.Text = "Использовать RegEx";
            this.chkUseRegEx.UseVisualStyleBackColor = true;
            // 
            // _secondaryPanel
            // 
            this._secondaryPanel.Controls.Add(this.btnCancel);
            this._secondaryPanel.Controls.Add(this.btnOK);
            this._secondaryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._secondaryPanel.Location = new System.Drawing.Point(0, 280);
            this._secondaryPanel.Name = "_secondaryPanel";
            this._secondaryPanel.Size = new System.Drawing.Size(367, 60);
            this._secondaryPanel.TabIndex = 19;
            this._secondaryPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._secondaryPanel_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(254, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(145, 20);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRequestDelay);
            this.groupBox2.Controls.Add(this.chkUseRequestDelay);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 77);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки запросов";
            // 
            // chkUseRequestDelay
            // 
            this.chkUseRequestDelay.AutoSize = true;
            this.chkUseRequestDelay.Location = new System.Drawing.Point(6, 22);
            this.chkUseRequestDelay.Name = "chkUseRequestDelay";
            this.chkUseRequestDelay.Size = new System.Drawing.Size(209, 19);
            this.chkUseRequestDelay.TabIndex = 0;
            this.chkUseRequestDelay.Text = "Делать паузы между запросами";
            this.chkUseRequestDelay.UseVisualStyleBackColor = true;
            // 
            // txtRequestDelay
            // 
            this.txtRequestDelay.Location = new System.Drawing.Point(82, 44);
            this.txtRequestDelay.Name = "txtRequestDelay";
            this.txtRequestDelay.Size = new System.Drawing.Size(133, 23);
            this.txtRequestDelay.TabIndex = 1;
            this.txtRequestDelay.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пауза (мс):";
            // 
            // chkUseHtmlSrcCode
            // 
            this.chkUseHtmlSrcCode.AutoSize = true;
            this.chkUseHtmlSrcCode.Location = new System.Drawing.Point(6, 22);
            this.chkUseHtmlSrcCode.Name = "chkUseHtmlSrcCode";
            this.chkUseHtmlSrcCode.Size = new System.Drawing.Size(188, 19);
            this.chkUseHtmlSrcCode.TabIndex = 22;
            this.chkUseHtmlSrcCode.Text = "Искать по тегу <img src=\"?\"/>";
            this.chkUseHtmlSrcCode.UseVisualStyleBackColor = true;
            // 
            // lblDefaultRegex
            // 
            this.lblDefaultRegex.AutoSize = true;
            this.lblDefaultRegex.Location = new System.Drawing.Point(6, 69);
            this.lblDefaultRegex.Name = "lblDefaultRegex";
            this.lblDefaultRegex.Size = new System.Drawing.Size(42, 15);
            this.lblDefaultRegex.TabIndex = 23;
            this.lblDefaultRegex.Text = "label1";
            // 
            // chkUseCustomRegexpPattern
            // 
            this.chkUseCustomRegexpPattern.AutoSize = true;
            this.chkUseCustomRegexpPattern.Location = new System.Drawing.Point(28, 87);
            this.chkUseCustomRegexpPattern.Name = "chkUseCustomRegexpPattern";
            this.chkUseCustomRegexpPattern.Size = new System.Drawing.Size(180, 19);
            this.chkUseCustomRegexpPattern.TabIndex = 24;
            this.chkUseCustomRegexpPattern.Text = "Использовать свой паттерн";
            this.chkUseCustomRegexpPattern.UseVisualStyleBackColor = true;
            // 
            // txtCustomRegexpPattern
            // 
            this.txtCustomRegexpPattern.Location = new System.Drawing.Point(28, 112);
            this.txtCustomRegexpPattern.Name = "txtCustomRegexpPattern";
            this.txtCustomRegexpPattern.Size = new System.Drawing.Size(187, 23);
            this.txtCustomRegexpPattern.TabIndex = 25;
            // 
            // chkUseEmbeddedStrategies
            // 
            this.chkUseEmbeddedStrategies.AutoSize = true;
            this.chkUseEmbeddedStrategies.Location = new System.Drawing.Point(6, 141);
            this.chkUseEmbeddedStrategies.Name = "chkUseEmbeddedStrategies";
            this.chkUseEmbeddedStrategies.Size = new System.Drawing.Size(172, 19);
            this.chkUseEmbeddedStrategies.TabIndex = 26;
            this.chkUseEmbeddedStrategies.Text = "Закрепленные операторы";
            this.chkUseEmbeddedStrategies.UseVisualStyleBackColor = true;
            // 
            // FetchOptionsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(367, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._secondaryPanel);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FetchOptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки приложения";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this._secondaryPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _secondaryPanel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseRegEx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequestDelay;
        private System.Windows.Forms.CheckBox chkUseRequestDelay;
        private System.Windows.Forms.CheckBox chkUseHtmlSrcCode;
        private System.Windows.Forms.CheckBox chkUseCustomRegexpPattern;
        private System.Windows.Forms.Label lblDefaultRegex;
        private System.Windows.Forms.TextBox txtCustomRegexpPattern;
        private System.Windows.Forms.CheckBox chkUseEmbeddedStrategies;
    }
}