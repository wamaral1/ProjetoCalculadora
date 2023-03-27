﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteDeFolhaDePagamento
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void ofdListaFuncionarios_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa foi desenvolvido " +
                "por Wellington Amaral utilizando C# em 03/2023.",
                "Sobre o Desenvolvedor", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}


