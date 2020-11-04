using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dblSaldoAtual = Convert.ToDouble(txtSaldoAtual.Text);
            double dblSaldoPretendido = Convert.ToDouble(txtSaldoPretendido.Text);
            double dblTaxa = Convert.ToDouble(txtTaxa.Text) / 100;
            int nAnos = 0;
            //a app ignora o facto de o saldo pretendido já ter sido alcançado pois o loop faz o "do" obrigatoriamente
            while (dblSaldoAtual < dblSaldoPretendido)
            {
                dblSaldoAtual = dblSaldoAtual + dblSaldoAtual * dblTaxa;
                nAnos = nAnos + 1;
            }
            /*ambas as formas são eficazes para corrigir o problema, porem alterar o operador para apenas < e apenas while
             * resolve o problema de forma mais eficiente a nivel de recursos do computador*/
            txtSaldoFinal.Text = dblSaldoAtual.ToString();
            txtAnosNecessarios.Text = nAnos.ToString();
        }
    }
}
