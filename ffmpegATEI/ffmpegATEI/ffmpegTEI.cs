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

namespace ffmpegATEI
{
    public partial class ffmpegTEI : Form
    {
        string inputItem = null;
        string outputDir = null;
        string preset = null;

        public ffmpegTEI()
        {
            InitializeComponent();         
        }

        private void ffmpegTEI_Load(object sender, EventArgs e)
        {
                    
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            cmdTextBox.ReadOnly = false;
        }

        private void presetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                }
           }
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
            //we need these set so they can be finally exposed to background thread
            inputItem = pathListBox.SelectedItem.ToString();
            outputDir = sevePathTextbox.Text;
            preset = presetsComboBox.SelectedItem.ToString();
            progressLabel.Text = "ffmpeg running in the background! Do NOT close this window";
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ffPresets.detectPreset(inputItem, outputDir, preset);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressLabel.Text = "Finished! You can now close this window!";
        }
    }

}

