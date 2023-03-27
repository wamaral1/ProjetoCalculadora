using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoReajusteDeSalarios.FormLeituraArquivo.Form1;

namespace ProjetoReajusteDeSalarios
{

    public partial class FormLeituraArquivo : Form
    {
        private RepositorioFuncionario repositorio =
        new RepositorioFuncionario();
        private BindingSource leituraSource =
        new BindingSource();
        public FormLeituraArquivo()
        {
            InitializeComponent();
            leituraSource.DataSource =
            repositorio.ObterTodos();
            dgvLeitura.DataSource = leituraSource;
        }
        public partial class Form1 : Form
    {
        public Form1()
        {
           // InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
        public class RepositorioFuncionario
        {
            private IList<Funcionario> funcionarios =
            new BindingList<Funcionario>();
            public void Inserir(Funcionario funcionario)
            {
                funcionarios.Add(funcionario);
            }
            public IList<Funcionario> ObterTodos()
            {
                return this.funcionarios;
            }
        }
            public class Funcionario
        {
            public int Codigo { get; set; }
            public double Salario { get; set; }
            public double Percentual
            {
                get
                {
                    if (this.Salario < 1000) return 15;
                    else if (this.Salario < 1500) return 10;
                    else
                        return 5;
                }
            }
            public double NovoSalario
            {
                get
                {
                    return (this.Salario * this.Percentual /
                    100) + this.Salario;
                }
            }
            
                private void button1_Click(object sender,
                EventArgs e)
                {
                    if (ofdListaFuncionarios.ShowDialog() ==
                    DialogResult.OK)
                    {
                        txtArquivo.Text = ofdListaFuncionarios.
                        FileName;
                        ProcessarArquivo(txtArquivo.Text);
                        if (repositorio.ObterTodos().Count > 0)
                        {
                            TotalizarValores(repositorio.
                            ObterTodos());
                        }
                    }
                }
                private void TotalizarValores(IList<Funcionario>
                dadosLidos)
                {
                    double totalSemReajuste = 0, totalComReajuste = 0;
                    foreach (var funcionario in dadosLidos)
                    {
                        totalSemReajuste += funcionario.Salario;
                        totalComReajuste += funcionario.
                        NovoSalario;
                    }
                    double percentualReajuste = (totalComReajuste
                    - totalSemReajuste) * 100 / totalSemReajuste;
                    lblTotalSemReajuste.Text = string.Format(
                    "{0:c}", totalSemReajuste);
                    lblTotalComReajuste.Text = string.Format(
                    "{0:c}", totalComReajuste);
                    lblPercentualDoReajuste.Text = string.Format(
                    "{0:n}%", percentualReajuste);
                }
                private void ProcessarArquivo(string nomeArquivo)
                {
                    repositorio.ObterTodos().Clear();
                    string linhaLida;
                    var arquivo =
                    new System.IO.StreamReader(@nomeArquivo);
                    while ((linhaLida = arquivo.ReadLine()) !=
                    null)
                    {
                        var dadosLidos = linhaLida.Split(';');
                        var funcionario = new Funcionario
                        {
                            Codigo = Convert.ToInt32(
                        dadosLidos[0]),
                            Salario = Convert.ToDouble(
                        dadosLidos[1])
                        };
                        repositorio.Inserir(funcionario);
                    }
                    arquivo.Close();
                }

            }


        }
        private void TotalizarValores(
        IList<Funcionario> dadosLidos)
        {
            double totalSemReajuste = 0, totalComReajuste = 0;
            foreach (var funcionario in dadosLidos)
            {
                totalSemReajuste += funcionario.Salario;
                totalComReajuste += funcionario.NovoSalario;
            }
            double percentualReajuste = (totalComReajuste 
totalSemReajuste)*100 / totalSemReajuste;
            lblTotalSemReajuste.Text = string.Format("{0:c}",
            totalSemReajuste);
            lblTotalComReajuste.Text = string.Format("{0:c}",
            totalComReajuste);
            lblPercentualDoReajuste.Text =
            string.Format("{0:n}%", percentualReajuste);
        }
        private void ProcessarArquivo(string nomeArquivo)
        {
            repositorio.ObterTodos().Clear();
            string linhaLida;
            var arquivo = new System.IO.StreamReader(
            @nomeArquivo);
            while ((linhaLida = arquivo.ReadLine()) != null)
            {
                var dadosLidos = linhaLida.Split(';');
                var funcionario = new Funcionario
                {
                    Codigo = Convert.ToInt32(dadosLidos[0]),
                    Salario = Convert.ToDouble(
                dadosLidos[1])
                };
                repositorio.Inserir(funcionario);
            }
            arquivo.Close();
        }
        private void BtnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            if (ofdListaFuncionarios.ShowDialog() ==
DialogResult.OK)
            {
                txtArquivo.Text = ofdListaFuncionarios.FileName;
                ProcessarArquivo(txtArquivo.Text);
                if (repositorio.ObterTodos().Count > 0)
                {
                    TotalizarValores(repositorio.ObterTodos());
                }
            }
        }
    }
}
