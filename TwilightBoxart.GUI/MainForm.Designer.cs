﻿namespace TwilightBoxart.GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnBrowseSd = new System.Windows.Forms.Button();
            this.txtSdRoot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtBoxart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseBoxart = new System.Windows.Forms.Button();
            this.chkManualBoxartLocation = new System.Windows.Forms.CheckBox();
            this.btnDetect = new System.Windows.Forms.Button();
            this.folderBrowseDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.lblSize2 = new System.Windows.Forms.Label();
            this.lblSize1 = new System.Windows.Forms.Label();
            this.chkBoxartSize = new System.Windows.Forms.CheckBox();
            this.btnGithub = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkAspectRatio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            //
            // btnBrowseSd
            //
            this.btnBrowseSd.Location = new System.Drawing.Point(698, 35);
            this.btnBrowseSd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseSd.Name = "btnBrowseSd";
            this.btnBrowseSd.Size = new System.Drawing.Size(152, 58);
            this.btnBrowseSd.TabIndex = 2;
            this.btnBrowseSd.Text = "Browse...";
            this.btnBrowseSd.UseVisualStyleBackColor = true;
            this.btnBrowseSd.Click += new System.EventHandler(this.btnBrowseSd_Click);
            //
            // txtSdRoot
            //
            this.txtSdRoot.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSdRoot.Location = new System.Drawing.Point(12, 46);
            this.txtSdRoot.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdRoot.Name = "txtSdRoot";
            this.txtSdRoot.Size = new System.Drawing.Size(674, 31);
            this.txtSdRoot.TabIndex = 1;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SD Root / Roms location:";
            //
            // txtLog
            //
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtLog.Location = new System.Drawing.Point(11, 278);
            this.txtLog.Margin = new System.Windows.Forms.Padding(6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(996, 360);
            this.txtLog.TabIndex = 10;
            //
            // txtBoxart
            //
            this.txtBoxart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxart.Location = new System.Drawing.Point(12, 137);
            this.txtBoxart.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxart.Name = "txtBoxart";
            this.txtBoxart.ReadOnly = true;
            this.txtBoxart.Size = new System.Drawing.Size(674, 31);
            this.txtBoxart.TabIndex = 4;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Boxart location:";
            //
            // btnBrowseBoxart
            //
            this.btnBrowseBoxart.Enabled = false;
            this.btnBrowseBoxart.Location = new System.Drawing.Point(698, 125);
            this.btnBrowseBoxart.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseBoxart.Name = "btnBrowseBoxart";
            this.btnBrowseBoxart.Size = new System.Drawing.Size(152, 58);
            this.btnBrowseBoxart.TabIndex = 5;
            this.btnBrowseBoxart.Text = "Browse...";
            this.btnBrowseBoxart.UseVisualStyleBackColor = true;
            this.btnBrowseBoxart.Click += new System.EventHandler(this.btnBrowseBoxart_Click);
            //
            // chkManualBoxartLocation
            //
            this.chkManualBoxartLocation.AutoSize = true;
            this.chkManualBoxartLocation.Location = new System.Drawing.Point(860, 137);
            this.chkManualBoxartLocation.Margin = new System.Windows.Forms.Padding(6);
            this.chkManualBoxartLocation.Name = "chkManualBoxartLocation";
            this.chkManualBoxartLocation.Size = new System.Drawing.Size(169, 29);
            this.chkManualBoxartLocation.TabIndex = 6;
            this.chkManualBoxartLocation.Text = "Set Manually";
            this.chkManualBoxartLocation.UseVisualStyleBackColor = true;
            this.chkManualBoxartLocation.CheckedChanged += new System.EventHandler(this.chkManualBoxartLocation_CheckedChanged);
            //
            // btnDetect
            //
            this.btnDetect.Location = new System.Drawing.Point(858, 35);
            this.btnDetect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(152, 58);
            this.btnDetect.TabIndex = 3;
            this.btnDetect.Text = "Detect SD";
            this.toolTip.SetToolTip(this.btnDetect, "Will try to detect your (Twilight++) SD card");
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            //
            // btnStart
            //
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(858, 648);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 58);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            //
            // numWidth
            //
            this.numWidth.Location = new System.Drawing.Point(92, 194);
            this.numWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(118, 31);
            this.numWidth.TabIndex = 7;
            this.numWidth.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numWidth.Visible = false;
            //
            // numHeight
            //
            this.numHeight.Location = new System.Drawing.Point(332, 194);
            this.numHeight.Margin = new System.Windows.Forms.Padding(6);
            this.numHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(118, 31);
            this.numHeight.TabIndex = 8;
            this.numHeight.Value = new decimal(new int[] {
            115,
            0,
            0,
            0});
            this.numHeight.Visible = false;
            //
            // lblSize2
            //
            this.lblSize2.AutoSize = true;
            this.lblSize2.Location = new System.Drawing.Point(240, 198);
            this.lblSize2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize2.Name = "lblSize2";
            this.lblSize2.Size = new System.Drawing.Size(80, 25);
            this.lblSize2.TabIndex = 13;
            this.lblSize2.Text = "Height:";
            this.lblSize2.Visible = false;
            //
            // lblSize1
            //
            this.lblSize1.AutoSize = true;
            this.lblSize1.Location = new System.Drawing.Point(6, 198);
            this.lblSize1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize1.Name = "lblSize1";
            this.lblSize1.Size = new System.Drawing.Size(73, 25);
            this.lblSize1.TabIndex = 14;
            this.lblSize1.Text = "Width:";
            this.lblSize1.Visible = false;
            //
            // chkBoxartSize
            //
            this.chkBoxartSize.AutoSize = true;
            this.chkBoxartSize.Location = new System.Drawing.Point(698, 196);
            this.chkBoxartSize.Margin = new System.Windows.Forms.Padding(6);
            this.chkBoxartSize.Name = "chkBoxartSize";
            this.chkBoxartSize.Size = new System.Drawing.Size(230, 29);
            this.chkBoxartSize.TabIndex = 9;
            this.chkBoxartSize.Text = "Change boxart size";
            this.chkBoxartSize.UseVisualStyleBackColor = true;
            this.chkBoxartSize.CheckedChanged += new System.EventHandler(this.chkBoxartSize_CheckedChanged);
            //
            // btnGithub
            //
            this.btnGithub.BackgroundImage = global::TwilightBoxart.GUI.Properties.Resources.GitHub_Mark_64px;
            this.btnGithub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGithub.Location = new System.Drawing.Point(11, 648);
            this.btnGithub.Margin = new System.Windows.Forms.Padding(4);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(58, 58);
            this.btnGithub.TabIndex = 11;
            this.toolTip.SetToolTip(this.btnGithub, "Visit the Github Repository.");
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            //
            // chkAspectRatio
            //
            this.chkAspectRatio.AutoSize = true;
            this.chkAspectRatio.Location = new System.Drawing.Point(698, 237);
            this.chkAspectRatio.Margin = new System.Windows.Forms.Padding(6);
            this.chkAspectRatio.Name = "chkAspectRatio";
            this.chkAspectRatio.Size = new System.Drawing.Size(318, 29);
            this.chkAspectRatio.TabIndex = 15;
            this.chkAspectRatio.Text = "Adjust to correct aspect ratio";
            this.toolTip.SetToolTip(this.chkAspectRatio, "Will resize the boxart to TwilightMenu++ compatible aspect ratio\'s");
            this.chkAspectRatio.UseVisualStyleBackColor = true;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 723);
            this.Controls.Add(this.chkAspectRatio);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.chkBoxartSize);
            this.Controls.Add(this.lblSize1);
            this.Controls.Add(this.lblSize2);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.chkManualBoxartLocation);
            this.Controls.Add(this.btnBrowseBoxart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxart);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSdRoot);
            this.Controls.Add(this.btnBrowseSd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TwilightBoxart";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseSd;
        private System.Windows.Forms.TextBox txtSdRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtBoxart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseBoxart;
        private System.Windows.Forms.CheckBox chkManualBoxartLocation;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDlg;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Label lblSize2;
        private System.Windows.Forms.Label lblSize1;
        private System.Windows.Forms.CheckBox chkBoxartSize;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox chkAspectRatio;
    }
}
