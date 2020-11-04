using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA1_LAB5_ExemploStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtTexto.Text.Substring(13, 5);
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtTexto.Text.Length.ToString();
        }
    }
}
