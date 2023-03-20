using System;
using System.Windows.Forms;

namespace ProjetoCalculaPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        RadioButton rbnSelecionado = null;

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por " +
                "WELLINGTON AMARAL utilizando C#.", "Sobre", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {
            
                RadioButton rbn = (RadioButton)sender;
                if (rbn.Checked)
                {
                    rbnSelecionado = rbn;
                    SetPesoIdeal();
                }
        }
        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal;
                if (rbnSelecionado.Text.Equals("Masculino"))
                    pesoIdeal = (72.7 * altura) - 58;
                else
                    pesoIdeal = (62.1 * altura) - 44.7;
                lblTxtPesoIdeal.Text = pesoIdeal.ToString("N");
            }
            catch (Exception e)
            {
                MessageBox.Show("Selecione o sexo e informe a " +
                    "altura corretamente", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }
}
