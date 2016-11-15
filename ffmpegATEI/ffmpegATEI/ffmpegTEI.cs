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
    }
}
