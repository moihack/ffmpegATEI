using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ffmpegATEI
{
    public partial class ffmpegTEI : Form
    {
        ffPresets ff;
        public customPreset customPre;
        string inputItem = null;
        string outputDir = null;
        string preset = null;        
        
        public ffmpegTEI()
        {
            InitializeComponent();
            toolTip1.AutoPopDelay = 3000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 250;
            toolTip1.ShowAlways = true;
            
            toolTip1.SetToolTip(this.AudioCodecsLabel, "Compresses and decompresses digital audio data according to a given audio file or streaming media audio coding format");
            toolTip1.SetToolTip(this.AudioBitrateLabel, "The lower the bitrate, the more the file has been compressed and the more you compress a file, the more of the original data is lost, and so the worse the playback sound quality will be.");
            toolTip1.SetToolTip(this.VideoCodecLabel, "It converts raw (uncompressed) digital video to a compressed format or vice versa.");
            toolTip1.SetToolTip(this.VideoBitrateLabel, "The bit rate is the amount of data dedicated to a second of video. So, the higher the bit rate, the better the video quality");
            toolTip1.SetToolTip(this.VideoResLabel, "In short, the number represents the number of horizontal lines the video has from top to bottom");
        }

        private void ffmpegTEI_Load(object sender, EventArgs e)
        {
           //customPre = new customPreset();
           ff = new ffPresets(this);
        }


        private void presetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(presetsComboBox.SelectedItem.ToString());
            if (presetsComboBox.SelectedItem.ToString().Contains("Custom"))
            {
                savePresetBtn.Enabled = true;

                var comboBoxes = this.Controls
                  .OfType<ComboBox>()
                  .Where(x => x.Name.StartsWith("comboBox"));

                foreach (var cmbBox in comboBoxes)
                {
                    cmbBox.Enabled = true;
                    cmbBox.SelectedIndex = 0;
                }

            }
            else
            {
                savePresetBtn.Enabled = false;

                var comboBoxes = this.Controls
                  .OfType<ComboBox>()
                  .Where(x => x.Name.StartsWith("comboBox"));

                foreach (var cmbBox in comboBoxes)
                {
                    cmbBox.Enabled = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Start on Desktop
            chooseFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            chooseFileDialog.Multiselect = true;
            if (chooseFileDialog.ShowDialog() == DialogResult.OK)
            {

                string[] result = chooseFileDialog.FileNames;
                foreach (string r in result)
                {
                    pathListBox.Items.Add(r);
                    pathListBox.SelectedIndex = pathListBox.SelectedIndex + 1;
                }
            }

            //pathListBox.SelectedIndex = 0;

        }

        private void choosePathButton_Click(object sender, EventArgs e)
        {
            //Start on Desktop
            choosePathDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (choosePathDialog.ShowDialog() == DialogResult.OK)
            {
                sevePathTextbox.Text = choosePathDialog.SelectedPath.ToString();
            }
        }

        private void sevePathTextbox_DoubleClick(object sender, EventArgs e)
        {
            if (choosePathDialog.ShowDialog() == DialogResult.OK)
            {
                sevePathTextbox.Text = choosePathDialog.SelectedPath.ToString();
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (pathListBox.Items.Count==0)
            {//before we do anything we must control if the listbox contains items.If not we 
             //we let the user choose then we put them to listbox and at the end we select the first of them.
                chooseFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                chooseFileDialog.Multiselect = true;
                if (chooseFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string[] result = chooseFileDialog.FileNames;
                    foreach (string r in result)
                    {
                        pathListBox.Items.Add(r);
                    }
                }

                pathListBox.SelectedIndex = 0;
                inputItem = pathListBox.SelectedItem.ToString();

            }
            //we need these set so they can be finally exposed to background thread
            try
            {
                inputItem = pathListBox.SelectedItem.ToString();
                outputDir = sevePathTextbox.Text;
                if (String.IsNullOrEmpty(outputDir))
                {
                    MessageBox.Show("You did not select the path where the converted file will"
                                + "be saved");
                    choosePathDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    if (choosePathDialog.ShowDialog() == DialogResult.OK)
                    {
                        sevePathTextbox.Text = choosePathDialog.SelectedPath.ToString();
                    }
                    outputDir = sevePathTextbox.Text;
                }
                preset = presetsComboBox.SelectedItem.ToString();
                progressLabel.Text = "ffmpeg running in the background! Do NOT close this window";
                presetCreator();
                //MessageBox.Show(customPre.abitrate + " " + customPre.vcodec);
                backgroundWorker1.RunWorkerAsync();
                //startConvert();
            }
            catch (NullReferenceException exc)
            {//catch the exception
                if (String.IsNullOrEmpty(inputItem))//control the variable which caused the exception
                {
                    Console.WriteLine(exc.ToString());
                    MessageBox.Show("You did not select a file to convert");
                    pathListBox.SelectedIndex = 0;
                    inputItem = pathListBox.SelectedItem.ToString();
                    if (presetsComboBox.SelectedItem!=null)
                    {//we must make this control because the value of variable preset is assigned after the assign of inputItem
                     //so even if the user chooses the preset practically the preset is not assigned to the value preset.
                     //If the selected item is not null we want to assign the value to variable preset
                     //in order not the following comparison be null and we show a message box which we do not want.
                        preset = presetsComboBox.SelectedItem.ToString();
                    }
                }
                if (String.IsNullOrEmpty(preset))//control the variable which caused the exception
                {
                    MessageBox.Show("You did not select a preset");
                } 
            }
        }

        private void startConvert()
        {
            //ffPresets.detectPreset(inputItem, outputDir, preset,this);
            //ff.detectPreset(inputItem, outputDir, preset);
            //ff.detectPreset(inputItem, outputDir, preset);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //MessageBox.Show(customPre.abitrate + " " + customPre.vcodec);
            ff.detectPreset(inputItem, outputDir, preset,this,progressBar1.Maximum,customPre);
            //ff.detectPreset(inputItem, outputDir, preset);
            //ff.detectPreset(inputItem, outputDir, preset);      
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressLabel.Text = "Finished! You can now close this window!";
            progressBar1.Value = progressBar1.Maximum;
            //backgroundWorker1.ReportProgress(0,1*10);
        }

        private void pathListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(pathListBox.SelectedItem.ToString());
            fileInfoTxtBox.Text = "";
            fileInfoTxtBox.Text = fileInfo.mediaInfo(pathListBox.SelectedItem.ToString());
            progressBar1.Maximum = Int32.Parse(fileInfoTxtBox.Text) + 1000;
            //MessageBox.Show(pathListBox.SelectedItem.ToString());
            //fileInfoTxtBox.Text = "";
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //MessageBox.Show("geia");
            //MessageBox.Show(e.ProgressPercentage.ToString());
            //Console.WriteLine(e.ProgressPercentage);
            //Console.WriteLine(e.ProgressPercentage.ToString());
            progressBar1.Value = e.ProgressPercentage;
            //progressBar1.Value = progressBar1.Value + 1;


        }

        public void updateMyPercentage(string test)
        {
            //richTextBox1.Text = test;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           // backgroundWorker1.ReportProgress();
        }

        private void savePresetBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("geia");
            //Application.StartupPath + "\\bin\\ffmpeg.exe";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Preset|*.preset";
            saveFileDialog1.Title = "Save a Preset file";
            saveFileDialog1.FileName = "customPreset.preset";
            //saveFileDialog1.InitialDirectory = Application.StartupPath + "\\presets\\";
            saveFileDialog1.ShowDialog();
            //MessageBox.Show(saveFileDialog1.FileName);

            // Create a file to write to.
            //string createText = "Hello and Welcome" + Environment.NewLine;
            //string path = Application.StartupPath + "\\presets\\test.txt";
           // File.WriteAllText(saveFileDialog1.FileName, presetCreator());

            // Open the file to read from. 
            //string readText = File.ReadAllText(path);
           // MessageBox.Show(readText);
        }

        private void presetCreator()
        {
            // string presetParameters = null;
            customPre = new customPreset();
            var comboBoxes = this.Controls
                 .OfType<ComboBox>()
                 .Where(x => x.Name.StartsWith("comboBox"));

            foreach (var cmbBox in comboBoxes)
            {
                if (cmbBox.Name.Equals("comboBoxAudioCodecsCollection"))
                {
                     customPre.acodec = comboBoxAudioCodecsCollection.SelectedItem.ToString();
                   // MessageBox.Show(cmbBox.Name + "t1");
                }

                if (cmbBox.Name.Equals("comboBoxAudioBitrateCollection"))
                {
                    customPre.abitrate = comboBoxAudioBitrateCollection.SelectedItem.ToString();
                    //Console.WriteLine("mphka");
                    // MessageBox.Show("geia1");
                    //MessageBox.Show(cmbBox.Name + "t2");
                }

                if (cmbBox.Name.Equals("comboBoxVideoCodecsCollection"))
                {
                    customPre.vcodec = comboBoxVideoCodecsCollection.SelectedItem.ToString();
                    // MessageBox.Show("geia2");
                    //MessageBox.Show(cmbBox.Name + "t3");
                }

                if (cmbBox.Name.Equals("comboBoxVideoBitratesCollection"))
                {
                    customPre.vbitrate = comboBoxVideoBitratesCollection.SelectedItem.ToString();
                    //MessageBox.Show("gamw" + comboBoxAudioCodecsCollection.SelectedItem.ToString());
                }

                if (cmbBox.Name.Equals("comboBoxVideoResolutionCollection"))
                {
                    customPre.resolution = comboBoxVideoResolutionCollection.SelectedItem.ToString();
                  //  MessageBox.Show("geia4");
                }

                //MessageBox.Show(customPre.abitrate + " " + customPre.vcodec);
            }

            //String parameters = "-y -i " + '"' + inputFile + '"' +  " -vn -acodec copy " + " " + '"' + outputDirectory + "\\AudioOnly.m4a" + '"';
           // return presetParameters;
        }

    }
}



