﻿namespace Guess_the_melody
{
    partial class fParam
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbInclude = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 272);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(92, 41);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(310, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 41);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cbInclude
            // 
            this.cbInclude.AutoSize = true;
            this.cbInclude.Location = new System.Drawing.Point(126, 285);
            this.cbInclude.Name = "cbInclude";
            this.cbInclude.Size = new System.Drawing.Size(112, 17);
            this.cbInclude.TabIndex = 3;
            this.cbInclude.Text = "Include subfolders";
            this.cbInclude.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(246, 446);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(10, 82);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(91, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Random Start";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cbMusicDuration.Location = new System.Drawing.Point(100, 38);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(49, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "20";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "60",
            "80",
            "100",
            "120",
            "180",
            "240",
            "360"});
            this.cbGameDuration.Location = new System.Drawing.Point(100, 20);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(49, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game time";
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbInclude);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.listBox1);
            this.Name = "fParam";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbInclude;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRandomStart;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}