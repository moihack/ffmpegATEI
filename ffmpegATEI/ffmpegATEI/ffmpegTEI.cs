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
                    MessageBox.Show("You didnt select the path where the converted file will"
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
                backgroundWorker1.RunWorkerAsync();
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



