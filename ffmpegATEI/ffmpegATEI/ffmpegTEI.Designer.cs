namespace ffmpegATEI
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
            this.components = new System.ComponentModel.Container();
            this.AudioCodecsLabel = new System.Windows.Forms.Label();
            this.AudioBitrateLabel = new System.Windows.Forms.Label();
            this.VideoCodecLabel = new System.Windows.Forms.Label();
            this.VideoBitrateLabel = new System.Windows.Forms.Label();
            this.VideoResLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.presetsLabel = new System.Windows.Forms.Label();
            this.presetsComboBox = new System.Windows.Forms.ComboBox();
            this.openFilesBtn = new System.Windows.Forms.Button();
            this.comboBoxVideoCodecsCollection = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioCodecsCollection = new System.Windows.Forms.ComboBox();
            this.comboBoxAudioBitrateCollection = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoBitratesCollection = new System.Windows.Forms.ComboBox();
            this.comboBoxVideoResolutionCollection = new System.Windows.Forms.ComboBox();
            this.chooseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pathListBox = new System.Windows.Forms.ListBox();
            this.choosePathDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.choosePathButton = new System.Windows.Forms.Button();
            this.sevePathTextbox = new System.Windows.Forms.TextBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.workerTests = new System.ComponentModel.BackgroundWorker();
            this.fileInfoTxtBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AudioCodecsLabel
            // 
            this.AudioCodecsLabel.AutoSize = true;
            this.AudioCodecsLabel.Location = new System.Drawing.Point(13, 237);
            this.AudioCodecsLabel.Name = "AudioCodecsLabel";
            this.AudioCodecsLabel.Size = new System.Drawing.Size(68, 13);
            this.AudioCodecsLabel.TabIndex = 1;
            this.AudioCodecsLabel.Text = "Audio Codec";
            // 
            // AudioBitrateLabel
            // 
            this.AudioBitrateLabel.AutoSize = true;
            this.AudioBitrateLabel.Location = new System.Drawing.Point(81, 237);
            this.AudioBitrateLabel.Name = "AudioBitrateLabel";
            this.AudioBitrateLabel.Size = new System.Drawing.Size(67, 13);
            this.AudioBitrateLabel.TabIndex = 2;
            this.AudioBitrateLabel.Text = "Audio Bitrate";
            // 
            // VideoCodecLabel
            // 
            this.VideoCodecLabel.AutoSize = true;
            this.VideoCodecLabel.Location = new System.Drawing.Point(154, 237);
            this.VideoCodecLabel.Name = "VideoCodecLabel";
            this.VideoCodecLabel.Size = new System.Drawing.Size(68, 13);
            this.VideoCodecLabel.TabIndex = 3;
            this.VideoCodecLabel.Text = "Video Codec";
            // 
            // VideoBitrateLabel
            // 
            this.VideoBitrateLabel.AutoSize = true;
            this.VideoBitrateLabel.Location = new System.Drawing.Point(222, 237);
            this.VideoBitrateLabel.Name = "VideoBitrateLabel";
            this.VideoBitrateLabel.Size = new System.Drawing.Size(67, 13);
            this.VideoBitrateLabel.TabIndex = 4;
            this.VideoBitrateLabel.Text = "Video Bitrate";
            // 
            // VideoResLabel
            // 
            this.VideoResLabel.AutoSize = true;
            this.VideoResLabel.Location = new System.Drawing.Point(292, 237);
            this.VideoResLabel.Name = "VideoResLabel";
            this.VideoResLabel.Size = new System.Drawing.Size(87, 13);
            this.VideoResLabel.TabIndex = 5;
            this.VideoResLabel.Text = "Video Resolution";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(617, 307);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // presetsLabel
            // 
            this.presetsLabel.AutoSize = true;
            this.presetsLabel.Location = new System.Drawing.Point(540, 237);
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
            "Custom"});
            this.presetsComboBox.Location = new System.Drawing.Point(527, 253);
            this.presetsComboBox.Name = "presetsComboBox";
            this.presetsComboBox.Size = new System.Drawing.Size(75, 21);
            this.presetsComboBox.TabIndex = 8;
            this.presetsComboBox.SelectedIndexChanged += new System.EventHandler(this.presetsComboBox_SelectedIndexChanged);
            // 
            // openFilesBtn
            // 
            this.openFilesBtn.Location = new System.Drawing.Point(617, 10);
            this.openFilesBtn.Name = "openFilesBtn";
            this.openFilesBtn.Size = new System.Drawing.Size(75, 23);
            this.openFilesBtn.TabIndex = 12;
            this.openFilesBtn.Text = "Open Files";
            this.openFilesBtn.UseVisualStyleBackColor = true;
            this.openFilesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxVideoCodecsCollection
            // 
            this.comboBoxVideoCodecsCollection.Enabled = false;
            this.comboBoxVideoCodecsCollection.FormattingEnabled = true;
            this.comboBoxVideoCodecsCollection.Items.AddRange(new object[] {
            "h264",
            "libx264",
            "mpeg2video",
            "mpeg4",
            "libxvid"});
            this.comboBoxVideoCodecsCollection.Location = new System.Drawing.Point(154, 253);
            this.comboBoxVideoCodecsCollection.Name = "comboBoxVideoCodecsCollection";
            this.comboBoxVideoCodecsCollection.Size = new System.Drawing.Size(65, 21);
            this.comboBoxVideoCodecsCollection.TabIndex = 16;
            // 
            // comboBoxAudioCodecsCollection
            // 
            this.comboBoxAudioCodecsCollection.Enabled = false;
            this.comboBoxAudioCodecsCollection.FormattingEnabled = true;
            this.comboBoxAudioCodecsCollection.Items.AddRange(new object[] {
            "aac",
            "mp3",
            "libvorbis"});
            this.comboBoxAudioCodecsCollection.Location = new System.Drawing.Point(14, 253);
            this.comboBoxAudioCodecsCollection.Name = "comboBoxAudioCodecsCollection";
            this.comboBoxAudioCodecsCollection.Size = new System.Drawing.Size(65, 21);
            this.comboBoxAudioCodecsCollection.TabIndex = 17;
            // 
            // comboBoxAudioBitrateCollection
            // 
            this.comboBoxAudioBitrateCollection.Enabled = false;
            this.comboBoxAudioBitrateCollection.FormattingEnabled = true;
            this.comboBoxAudioBitrateCollection.Items.AddRange(new object[] {
            "128k",
            "256k",
            "320k"});
            this.comboBoxAudioBitrateCollection.Location = new System.Drawing.Point(85, 253);
            this.comboBoxAudioBitrateCollection.Name = "comboBoxAudioBitrateCollection";
            this.comboBoxAudioBitrateCollection.Size = new System.Drawing.Size(64, 21);
            this.comboBoxAudioBitrateCollection.TabIndex = 18;
            // 
            // comboBoxVideoBitratesCollection
            // 
            this.comboBoxVideoBitratesCollection.Enabled = false;
            this.comboBoxVideoBitratesCollection.FormattingEnabled = true;
            this.comboBoxVideoBitratesCollection.Items.AddRange(new object[] {
            "300k",
            "600k",
            "800k",
            "1000k",
            "1200k"});
            this.comboBoxVideoBitratesCollection.Location = new System.Drawing.Point(225, 253);
            this.comboBoxVideoBitratesCollection.Name = "comboBoxVideoBitratesCollection";
            this.comboBoxVideoBitratesCollection.Size = new System.Drawing.Size(64, 21);
            this.comboBoxVideoBitratesCollection.TabIndex = 19;
            // 
            // comboBoxVideoResolutionCollection
            // 
            this.comboBoxVideoResolutionCollection.Enabled = false;
            this.comboBoxVideoResolutionCollection.FormattingEnabled = true;
            this.comboBoxVideoResolutionCollection.Items.AddRange(new object[] {
            "320x240",
            "640x480",
            "1280x720",
            "1920x1080"});
            this.comboBoxVideoResolutionCollection.Location = new System.Drawing.Point(295, 253);
            this.comboBoxVideoResolutionCollection.Name = "comboBoxVideoResolutionCollection";
            this.comboBoxVideoResolutionCollection.Size = new System.Drawing.Size(84, 21);
            this.comboBoxVideoResolutionCollection.TabIndex = 20;
            // 
            // chooseFileDialog
            // 
            this.chooseFileDialog.FileName = "chooseFileDialog";
            // 
            // pathListBox
            // 
            this.pathListBox.FormattingEnabled = true;
            this.pathListBox.Location = new System.Drawing.Point(12, 10);
            this.pathListBox.Name = "pathListBox";
            this.pathListBox.Size = new System.Drawing.Size(590, 69);
            this.pathListBox.TabIndex = 21;
            this.pathListBox.SelectedIndexChanged += new System.EventHandler(this.pathListBox_SelectedIndexChanged);
            // 
            // choosePathButton
            // 
            this.choosePathButton.Location = new System.Drawing.Point(618, 83);
            this.choosePathButton.Name = "choosePathButton";
            this.choosePathButton.Size = new System.Drawing.Size(75, 23);
            this.choosePathButton.TabIndex = 23;
            this.choosePathButton.Text = "Output Dir";
            this.choosePathButton.UseVisualStyleBackColor = true;
            this.choosePathButton.Click += new System.EventHandler(this.choosePathButton_Click);
            // 
            // sevePathTextbox
            // 
            this.sevePathTextbox.Location = new System.Drawing.Point(12, 85);
            this.sevePathTextbox.Name = "sevePathTextbox";
            this.sevePathTextbox.ReadOnly = true;
            this.sevePathTextbox.Size = new System.Drawing.Size(590, 20);
            this.sevePathTextbox.TabIndex = 25;
            this.sevePathTextbox.DoubleClick += new System.EventHandler(this.sevePathTextbox_DoubleClick);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(221, 317);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(275, 13);
            this.progressLabel.TabIndex = 26;
            this.progressLabel.Text = "Select input file,output directory,preset and press convert";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // fileInfoTxtBox
            // 
            this.fileInfoTxtBox.Location = new System.Drawing.Point(12, 124);
            this.fileInfoTxtBox.Name = "fileInfoTxtBox";
            this.fileInfoTxtBox.Size = new System.Drawing.Size(592, 99);
            this.fileInfoTxtBox.TabIndex = 27;
            this.fileInfoTxtBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "FileInfo";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(680, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // ffmpegTEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 362);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fileInfoTxtBox);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.sevePathTextbox);
            this.Controls.Add(this.choosePathButton);
            this.Controls.Add(this.pathListBox);
            this.Controls.Add(this.comboBoxVideoResolutionCollection);
            this.Controls.Add(this.comboBoxVideoBitratesCollection);
            this.Controls.Add(this.comboBoxAudioBitrateCollection);
            this.Controls.Add(this.comboBoxAudioCodecsCollection);
            this.Controls.Add(this.comboBoxVideoCodecsCollection);
            this.Controls.Add(this.openFilesBtn);
            this.Controls.Add(this.presetsComboBox);
            this.Controls.Add(this.presetsLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.VideoResLabel);
            this.Controls.Add(this.VideoBitrateLabel);
            this.Controls.Add(this.VideoCodecLabel);
            this.Controls.Add(this.AudioBitrateLabel);
            this.Controls.Add(this.AudioCodecsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ffmpegTEI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ffmpegTEI";
            this.Load += new System.EventHandler(this.ffmpegTEI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AudioCodecsLabel;
        private System.Windows.Forms.Label AudioBitrateLabel;
        private System.Windows.Forms.Label VideoCodecLabel;
        private System.Windows.Forms.Label VideoBitrateLabel;
        private System.Windows.Forms.Label VideoResLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label presetsLabel;
        private System.Windows.Forms.ComboBox presetsComboBox;
        private System.Windows.Forms.Button openFilesBtn;
        private System.Windows.Forms.ComboBox comboBoxVideoCodecsCollection;
        private System.Windows.Forms.ComboBox comboBoxAudioCodecsCollection;
        private System.Windows.Forms.ComboBox comboBoxAudioBitrateCollection;
        private System.Windows.Forms.ComboBox comboBoxVideoBitratesCollection;
        private System.Windows.Forms.ComboBox comboBoxVideoResolutionCollection;
        private System.Windows.Forms.OpenFileDialog chooseFileDialog;
        private System.Windows.Forms.ListBox pathListBox;
        private System.Windows.Forms.FolderBrowserDialog choosePathDialog;
        private System.Windows.Forms.Button choosePathButton;
        private System.Windows.Forms.TextBox sevePathTextbox;
        private System.Windows.Forms.Label progressLabel;
        public System.ComponentModel.BackgroundWorker workerTests;
        private System.Windows.Forms.RichTextBox fileInfoTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

