﻿namespace AeSplashChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.importbtn = new System.Windows.Forms.Button();
            this.exportbtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.aefolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.splashLabel = new System.Windows.Forms.Label();
            this.Github = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // importbtn
            // 
            this.importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.importbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("importbtn.BackgroundImage")));
            this.importbtn.FlatAppearance.BorderSize = 0;
            this.importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importbtn.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.importbtn.Image = ((System.Drawing.Image)(resources.GetObject("importbtn.Image")));
            this.importbtn.Location = new System.Drawing.Point(14, 66);
            this.importbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(117, 245);
            this.importbtn.TabIndex = 0;
            this.importbtn.Text = "import";
            this.importbtn.UseVisualStyleBackColor = false;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // exportbtn
            // 
            this.exportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.exportbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportbtn.BackgroundImage")));
            this.exportbtn.FlatAppearance.BorderSize = 0;
            this.exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportbtn.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.exportbtn.Image = ((System.Drawing.Image)(resources.GetObject("exportbtn.Image")));
            this.exportbtn.Location = new System.Drawing.Point(502, 65);
            this.exportbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(120, 245);
            this.exportbtn.TabIndex = 0;
            this.exportbtn.Text = "export";
            this.exportbtn.UseVisualStyleBackColor = false;
            this.exportbtn.Click += new System.EventHandler(this.exportbtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(139, 65);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 245);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.UseWaitCursor = true;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "importFileDialog";
            // 
            // splashLabel
            // 
            this.splashLabel.AutoSize = true;
            this.splashLabel.BackColor = System.Drawing.Color.Transparent;
            this.splashLabel.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.splashLabel.Location = new System.Drawing.Point(204, 79);
            this.splashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.splashLabel.Name = "splashLabel";
            this.splashLabel.Size = new System.Drawing.Size(212, 23);
            this.splashLabel.TabIndex = 1;
            this.splashLabel.Text = "Current Splash Screen:";
            // 
            // Github
            // 
            this.Github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.Github.FlatAppearance.BorderSize = 0;
            this.Github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Github.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.Github.Location = new System.Drawing.Point(139, 317);
            this.Github.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(110, 45);
            this.Github.TabIndex = 0;
            this.Github.Text = "github";
            this.Github.UseVisualStyleBackColor = false;
            this.Github.Click += new System.EventHandler(this.githubbtn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(451, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "made by vy#0069";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Propaganda", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(257, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "youtube";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(382, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "discord";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Seagram tfb", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(279, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "grimswapper";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(635, 391);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.splashLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.exportbtn);
            this.Controls.Add(this.importbtn);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrimSwapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importbtn;
        private System.Windows.Forms.Button exportbtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FolderBrowserDialog aefolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Label splashLabel;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

