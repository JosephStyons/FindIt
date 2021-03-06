﻿namespace Findit
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBlinkFinish = new System.Windows.Forms.CheckBox();
            this.cbBlinkEvery = new System.Windows.Forms.CheckBox();
            this.cbBlinkFirst = new System.Windows.Forms.CheckBox();
            this.lblBlinkTitle = new System.Windows.Forms.Label();
            this.lblRunSearchAfterLoad = new System.Windows.Forms.Label();
            this.lblRecommendThreadCount = new System.Windows.Forms.Label();
            this.lblSelectedThreadCount = new System.Windows.Forms.Label();
            this.lblSearchThreadCount = new System.Windows.Forms.Label();
            this.tbarThreadCount = new System.Windows.Forms.TrackBar();
            this.cbRunSearchAfterLoad = new System.Windows.Forms.CheckBox();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.lblInvalidNotice = new System.Windows.Forms.Label();
            this.txbCustomEditorExe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarThreadCount)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBlinkFinish);
            this.panel1.Controls.Add(this.cbBlinkEvery);
            this.panel1.Controls.Add(this.cbBlinkFirst);
            this.panel1.Controls.Add(this.lblBlinkTitle);
            this.panel1.Controls.Add(this.lblRunSearchAfterLoad);
            this.panel1.Controls.Add(this.lblRecommendThreadCount);
            this.panel1.Controls.Add(this.lblSelectedThreadCount);
            this.panel1.Controls.Add(this.lblSearchThreadCount);
            this.panel1.Controls.Add(this.tbarThreadCount);
            this.panel1.Controls.Add(this.cbRunSearchAfterLoad);
            this.panel1.Controls.Add(this.txbColor);
            this.panel1.Controls.Add(this.lblInvalidNotice);
            this.panel1.Controls.Add(this.txbCustomEditorExe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 390);
            this.panel1.TabIndex = 0;
            // 
            // cbBlinkFinish
            // 
            this.cbBlinkFinish.AutoSize = true;
            this.cbBlinkFinish.Location = new System.Drawing.Point(13, 281);
            this.cbBlinkFinish.Name = "cbBlinkFinish";
            this.cbBlinkFinish.Size = new System.Drawing.Size(182, 22);
            this.cbBlinkFinish.TabIndex = 24;
            this.cbBlinkFinish.Text = "When the search finishes";
            this.cbBlinkFinish.UseVisualStyleBackColor = true;
            // 
            // cbBlinkEvery
            // 
            this.cbBlinkEvery.AutoSize = true;
            this.cbBlinkEvery.Location = new System.Drawing.Point(13, 253);
            this.cbBlinkEvery.Name = "cbBlinkEvery";
            this.cbBlinkEvery.Size = new System.Drawing.Size(194, 22);
            this.cbBlinkEvery.TabIndex = 23;
            this.cbBlinkEvery.Text = "Every time a result is found";
            this.cbBlinkEvery.UseVisualStyleBackColor = true;
            this.cbBlinkEvery.CheckedChanged += new System.EventHandler(this.cbBlinkEvery_CheckedChanged);
            // 
            // cbBlinkFirst
            // 
            this.cbBlinkFirst.AutoSize = true;
            this.cbBlinkFirst.Location = new System.Drawing.Point(13, 225);
            this.cbBlinkFirst.Name = "cbBlinkFirst";
            this.cbBlinkFirst.Size = new System.Drawing.Size(207, 22);
            this.cbBlinkFirst.TabIndex = 22;
            this.cbBlinkFirst.Text = "When the first result is found";
            this.cbBlinkFirst.UseVisualStyleBackColor = true;
            // 
            // lblBlinkTitle
            // 
            this.lblBlinkTitle.AutoSize = true;
            this.lblBlinkTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlinkTitle.Location = new System.Drawing.Point(10, 204);
            this.lblBlinkTitle.Name = "lblBlinkTitle";
            this.lblBlinkTitle.Size = new System.Drawing.Size(168, 18);
            this.lblBlinkTitle.TabIndex = 21;
            this.lblBlinkTitle.Text = "Blink in the taskbar when:";
            // 
            // lblRunSearchAfterLoad
            // 
            this.lblRunSearchAfterLoad.AutoSize = true;
            this.lblRunSearchAfterLoad.Location = new System.Drawing.Point(13, 79);
            this.lblRunSearchAfterLoad.Name = "lblRunSearchAfterLoad";
            this.lblRunSearchAfterLoad.Size = new System.Drawing.Size(245, 18);
            this.lblRunSearchAfterLoad.TabIndex = 20;
            this.lblRunSearchAfterLoad.Text = "Run saved searches after loading them";
            // 
            // lblRecommendThreadCount
            // 
            this.lblRecommendThreadCount.AutoSize = true;
            this.lblRecommendThreadCount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendThreadCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecommendThreadCount.Location = new System.Drawing.Point(119, 127);
            this.lblRecommendThreadCount.Name = "lblRecommendThreadCount";
            this.lblRecommendThreadCount.Size = new System.Drawing.Size(91, 18);
            this.lblRecommendThreadCount.TabIndex = 19;
            this.lblRecommendThreadCount.Text = "set from code";
            // 
            // lblSelectedThreadCount
            // 
            this.lblSelectedThreadCount.AutoSize = true;
            this.lblSelectedThreadCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedThreadCount.Location = new System.Drawing.Point(377, 148);
            this.lblSelectedThreadCount.Name = "lblSelectedThreadCount";
            this.lblSelectedThreadCount.Size = new System.Drawing.Size(20, 23);
            this.lblSelectedThreadCount.TabIndex = 18;
            this.lblSelectedThreadCount.Text = "1";
            // 
            // lblSearchThreadCount
            // 
            this.lblSearchThreadCount.AutoSize = true;
            this.lblSearchThreadCount.Location = new System.Drawing.Point(13, 127);
            this.lblSearchThreadCount.Name = "lblSearchThreadCount";
            this.lblSearchThreadCount.Size = new System.Drawing.Size(99, 18);
            this.lblSearchThreadCount.TabIndex = 17;
            this.lblSearchThreadCount.Text = "Search threads";
            // 
            // tbarThreadCount
            // 
            this.tbarThreadCount.Location = new System.Drawing.Point(17, 148);
            this.tbarThreadCount.Maximum = 50;
            this.tbarThreadCount.Minimum = 1;
            this.tbarThreadCount.Name = "tbarThreadCount";
            this.tbarThreadCount.Size = new System.Drawing.Size(354, 45);
            this.tbarThreadCount.TabIndex = 16;
            this.tbarThreadCount.Value = 1;
            this.tbarThreadCount.ValueChanged += new System.EventHandler(this.tbarThreadCount_ValueChanged);
            // 
            // cbRunSearchAfterLoad
            // 
            this.cbRunSearchAfterLoad.AutoSize = true;
            this.cbRunSearchAfterLoad.Location = new System.Drawing.Point(264, 82);
            this.cbRunSearchAfterLoad.Name = "cbRunSearchAfterLoad";
            this.cbRunSearchAfterLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRunSearchAfterLoad.Size = new System.Drawing.Size(15, 14);
            this.cbRunSearchAfterLoad.TabIndex = 15;
            this.cbRunSearchAfterLoad.UseVisualStyleBackColor = true;
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(650, 3);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(43, 26);
            this.txbColor.TabIndex = 14;
            this.txbColor.Text = "color";
            this.txbColor.Visible = false;
            // 
            // lblInvalidNotice
            // 
            this.lblInvalidNotice.AutoSize = true;
            this.lblInvalidNotice.Font = new System.Drawing.Font("Calibri", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidNotice.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidNotice.Location = new System.Drawing.Point(417, 35);
            this.lblInvalidNotice.Name = "lblInvalidNotice";
            this.lblInvalidNotice.Size = new System.Drawing.Size(143, 18);
            this.lblInvalidNotice.TabIndex = 13;
            this.lblInvalidNotice.Text = "This file does not exist";
            this.lblInvalidNotice.Visible = false;
            // 
            // txbCustomEditorExe
            // 
            this.txbCustomEditorExe.Location = new System.Drawing.Point(16, 31);
            this.txbCustomEditorExe.Margin = new System.Windows.Forms.Padding(4);
            this.txbCustomEditorExe.Name = "txbCustomEditorExe";
            this.txbCustomEditorExe.Size = new System.Drawing.Size(354, 26);
            this.txbCustomEditorExe.TabIndex = 2;
            this.txbCustomEditorExe.Text = "C:\\windows\\notepad.exe";
            this.txbCustomEditorExe.TextChanged += new System.EventHandler(this.txbCustomEditorExe_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom editor";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(378, 31);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 26);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 68);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(556, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 68);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 68);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarThreadCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbCustomEditorExe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInvalidNotice;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.CheckBox cbRunSearchAfterLoad;
        private System.Windows.Forms.Label lblSearchThreadCount;
        private System.Windows.Forms.TrackBar tbarThreadCount;
        private System.Windows.Forms.Label lblSelectedThreadCount;
        private System.Windows.Forms.Label lblRecommendThreadCount;
        private System.Windows.Forms.Label lblRunSearchAfterLoad;
        private System.Windows.Forms.Label lblBlinkTitle;
        private System.Windows.Forms.CheckBox cbBlinkFinish;
        private System.Windows.Forms.CheckBox cbBlinkEvery;
        private System.Windows.Forms.CheckBox cbBlinkFirst;
    }
}