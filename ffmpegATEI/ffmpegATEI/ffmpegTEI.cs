using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffmpegATEI
{
    public partial class ffmpegTEI : Form
    {
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
            chooseFileDialog.InitialDirectory = "C:\\Users\\user1\\Desktop";
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
    }
}
