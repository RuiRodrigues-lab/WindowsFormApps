using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbIOS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIOS.Checked == true)
                picIOS.Visible = true;
            else
                picIOS.Visible = false;
        }

        private void cbANDROID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbANDROID.Checked == true)
                picANDROID.Visible = true;
            else
                picANDROID.Visible = false;
        }
    }
}
