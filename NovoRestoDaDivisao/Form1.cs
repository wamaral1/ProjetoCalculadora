using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoRestoDaDivisao
{
    public partial class Form1 : Form
    {
        //variaveis globais
        double dividendo=0, divisor=0, resultado=0;

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Desenvolvido por WELLINGTON AMARAL utilizando " +
                "c#", "Sobre!!!", MessageBoxButtons.OK);
        }

        private void txtDivisor_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRealizarDivisao_Click(object sender, EventArgs e)
        {
            if (txtDividendo.Text == "" || txtDivisor.Text == "")
                MessageBox.Show("Por favor, informar DIVIDENDO e/ou DIVISOR." +
                    "", "ATENCAO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (double.TryParse(txtDividendo.Text, out dividendo) &&
            double.TryParse(txtDivisor.Text, out divisor))
            {
                if (divisor == 0)
                {
                    MessageBox.Show("Para realizar esta operacao " +
                        "DIVISOR nao pode ser " +
                        "0", "ATENCAO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    resultado = dividendo % divisor;
                    txtResto.Text = resultado.ToString();
            }
            else
                MessageBox.Show("DIVIDENDO e/ou DIVISOR Inválidos. " +
                    "Apenas números devem ser digitados.",
                    "ATENCAO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    
}
