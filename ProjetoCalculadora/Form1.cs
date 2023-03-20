using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        //VARIAVEIS GLOBAIS
        double valor1=0, valor2=0, resultado=0;
        string txtOperacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExecutarOperacao_Click(object sender, EventArgs e)
        {
            // 0 - SOMA, 1 = SUBTRAIR, 2 = MULTIPLICAR, 3 = DIVIDIR


            txtOperacao = "";
            txtOperacao = comboBoxOperacao.SelectedIndex.ToString();
            if (txtValor1.Text == "" || txtValor2.Text == "")
            MessageBox.Show("Por favor, informar Valor 1 e/ou Valor 2." +
                "", "ATENCAO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //Esta funcao realiza a conversao da String em Double
            //o IF somente é executado caso o valor seja numerico

            if (double.TryParse(txtValor1.Text, out valor1) &&
            double.TryParse(txtValor2.Text, out valor2))
            {
                
                if (txtOperacao == "0")
                {
                    resultado = valor1 + valor2;
                    txtResultado.Text = resultado.ToString();
                }
                txtOperacao = comboBoxOperacao.SelectedIndex.ToString();
                if (txtOperacao == "1")
                {
                    resultado = valor1 - valor2;
                    txtResultado.Text = resultado.ToString();
                }
                txtOperacao = comboBoxOperacao.SelectedIndex.ToString();
                if (txtOperacao == "2")
                {
                    resultado = valor1 * valor2;
                    txtResultado.Text = resultado.ToString();
                }
                txtOperacao = comboBoxOperacao.SelectedIndex.ToString();
                if (txtOperacao == "3")
                {
                    if (txtValor2.Text =="0")
                    { 
                    MessageBox.Show("Para realizar esta operacao " +
                        "o Campo Valor 2 nao pode ser " +
                        "0", "ATENCAO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        resultado = valor1 / valor2;
                    txtResultado.Text = resultado.ToString();
                }
                
            }
            else
                MessageBox.Show("Valor 1 e/ou Valor 2 Inválidos. " +
                    "Apenas números devem ser digitados.", "ATENCAO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            txtValor1.Text="";
            txtValor2.Text ="";
            txtResultado.Text = "";
            comboBoxOperacao.SelectedIndex = -1;
          

        }

        private void informacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por " +
                "WELLINGTON AMARAL, utilizando C#", "SOBRE",
                MessageBoxButtons.OK);
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
