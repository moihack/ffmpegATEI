﻿namespace ffmpegATEI
{
    partial class ffmpegTEI
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.presetsLabel = new System.Windows.Forms.Label();
            this.presetsComboBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pathListBox = new System.Windows.Forms.ListBox();
            this.choosePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.choosePathButton = new System.Windows.Forms.Button();
            this.messageChooseLabel = new System.Windows.Forms.Label();
            this.sevePathTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 287);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(591, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio Codec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Audio Bitrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Video Codec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Video Bitrate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Video Resolution";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(617, 287);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            // 
            // presetsLabel
            // 
            this.presetsLabel.AutoSize = true;
            this.presetsLabel.Location = new System.Drawing.Point(631, 143);
            this.presetsLabel.Name = "presetsLabel";
            this.presetsLabel.Size = new System.Drawing.Size(42, 13);
            this.presetsLabel.TabIndex = 7;
            this.presetsLabel.Text = "Presets";
            // 
            // presetsComboBox
            // 
            this.presetsComboBox.FormattingEnabled = true;
            this.presetsComboBox.Items.AddRange(new object[] {
            "Audio Only",
            "Video Only",
            "PSP",
            "presetX",
            "presetY"});
            this.presetsComboBox.Location = new System.Drawing.Point(616, 159);
            this.presetsComboBox.Name = "presetsComboBox";
            this.presetsComboBox.Size = new System.Drawing.Size(75, 21);
            this.presetsComboBox.TabIndex = 8;
            this.presetsComboBox.SelectedIndexChanged += new System.EventHandler(this.presetsComboBox_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(591, 20);
            this.textBox3.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(12, 262);
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.ReadOnly = true;
            this.cmdTextBox.Size = new System.Drawing.Size(591, 20);
            this.cmdTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "command:";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(617, 262);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 159);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(224, 159);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(64, 21);
            this.comboBox4.TabIndex = 19;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(294, 159);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(84, 21);
            this.comboBox5.TabIndex = 20;
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.FileName = "chooseFileDialog";
            // 
            // pathListBox
            // 
            this.pathListBox.FormattingEnabled = true;
            this.pathListBox.Location = new System.Drawing.Point(13, 39);
            this.pathListBox.Name = "pathListBox";
            this.pathListBox.Size = new System.Drawing.Size(189, 95);
            this.pathListBox.TabIndex = 21;
            // 
            // choosePathButton
            // 
            this.choosePathButton.Location = new System.Drawing.Point(617, 46);
            this.choosePathButton.Name = "choosePathButton";
            this.choosePathButton.Size = new System.Drawing.Size(75, 23);
            this.choosePathButton.TabIndex = 23;
            this.choosePathButton.Text = "Choose";
            this.choosePathButton.UseVisualStyleBackColor = true;
            this.choosePathButton.Click += new System.EventHandler(this.choosePathButton_Click);
            // 
            // messageChooseLabel
            // 
            this.messageChooseLabel.AutoSize = true;
            this.messageChooseLabel.Location = new System.Drawing.Point(323, 46);
            this.messageChooseLabel.Name = "messageChooseLabel";
            this.messageChooseLabel.Size = new System.Drawing.Size(288, 13);
            this.messageChooseLabel.TabIndex = 24;
            this.messageChooseLabel.Text = "Please choose the path you want to save the converted file";
            // 
            // sevePathTextbox
            // 
            this.sevePathTextbox.Location = new System.Drawing.Point(326, 75);
            this.sevePathTextbox.Name = "sevePathTextbox";
            this.sevePathTextbox.ReadOnly = true;
            this.sevePathTextbox.Size = new System.Drawing.Size(285, 20);
            this.sevePathTextbox.TabIndex = 25;
            this.sevePathTextbox.DoubleClick += new System.EventHandler(this.sevePathTextbox_DoubleClick);
            // 
            // ffmpegTEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 322);
            this.Controls.Add(this.sevePathTextbox);
            this.Controls.Add(this.messageChooseLabel);
            this.Controls.Add(this.choosePathButton);
            this.Controls.Add(this.pathListBox);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.presetsComboBox);
            this.Controls.Add(this.presetsLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "ffmpegTEI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ffmpegTEI";
            this.Load += new System.EventHandler(this.ffmpegTEI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label presetsLabel;
        private System.Windows.Forms.ComboBox presetsComboBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.ListBox pathListBox;
        private System.Windows.Forms.FolderBrowserDialog choosePathDialog;
        private System.Windows.Forms.Button choosePathButton;
        private System.Windows.Forms.Label messageChooseLabel;
        private System.Windows.Forms.TextBox sevePathTextbox;
    }
}

