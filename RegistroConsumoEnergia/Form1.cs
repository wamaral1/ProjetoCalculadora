using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroConsumoEnergia
{
    public partial class Form1 : Form
    {
        class Leitura
        {
            //Atributos
            public string Casa { get; set; }
            public double Consumo { get; set; }
            public double Desconto
            {
                get { return Consumo * 0.2; }
            }
            //Construtor da Classe
            public Leitura(string casa, double consumo)
            {
                this.Casa = casa;
                this.Consumo = consumo;

            }
            //Sobrescrita de método
            //Método Pré-Definido
            //Equal é Utilizado para Comparar Objs
            public override bool Equals(object obj)
            {
                Leitura leitura = obj as Leitura;
                if (leitura == null)
                { return false; }
                return (Casa.Equals(leitura.Casa));
            }
            public override int GetHashCode()
            {
                return new { Casa, Consumo }.GetHashCode();
            }
        }
    }
}


