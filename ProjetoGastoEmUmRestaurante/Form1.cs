using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGastoEmUmRestaurante
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa desenvolvido por " +
                "WELLINGTON AMARAL utilizando C# ", "Sobre", 
                MessageBoxButtons.OK);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double despesa = 0;
            if (double.TryParse(txtDespesa.Text, out despesa))
            {
                txtComGorjeta.Text = (despesa*1.10).ToString("N");
            
            }
            else
                MessageBox.Show("Apenas números devem ser digitados."
                    , "ATENCAO!!!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
        }
    }
}
