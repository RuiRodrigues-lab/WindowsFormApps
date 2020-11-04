using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbBASE_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEXPOENTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCALCULAR_Click(object sender, EventArgs e)
        {
            double Base, Expoente, Resultado=1;

            Base = Convert.ToDouble(tbBASE.Text);
            Expoente = Convert.ToDouble(tbEXPOENTE.Text);


            for(int i=0; i<Expoente; i++) 
            {
                Resultado = Resultado * Base;
            }

            tbRESULTADO.Text = Convert.ToString(Resultado);


        }

        private void tbRESULTADO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
