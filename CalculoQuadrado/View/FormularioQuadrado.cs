using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoQuadrado.View
{
    public partial class FormularioQuadrado : Form
    {
        public FormularioQuadrado()
        {
            InitializeComponent();
        }
        //Criar uma Função/metodo
        private double Quadrado(double num)
        {
            double resul = num * num;
            return resul;
        }
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tbx_Valor.Text);
            double Quand;
            Quand = num * num;
            tbx_Resultado.Text = "O valor quadrado de " + num + " é " + Quadrado(num);
            tbx_Valor.Focus();
            tbx_Valor.SelectAll();
        }

    }
}
