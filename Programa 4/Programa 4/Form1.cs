using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbIOS_CheckedChanged(object sender, EventArgs e)//agora é o objecto Radio Button
        {
            if (rbIOS.Checked == true)// agora inves de cb temos de meter rb
                picIOS.Visible = true;
            else
                picIOS.Visible = false;
        }

        private void rbANDROID_CheckedChanged(object sender, EventArgs e)//agora é o objecto Radio Button
        {
            if (rbANDROID.Checked == true)// agora inves de cb temos de meter rb
                picANDROID.Visible = true;
            else
                picANDROID.Visible = false;
        }
    }
}
