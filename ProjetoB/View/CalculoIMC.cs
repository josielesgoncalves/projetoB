using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoB.View
{
    public partial class CalculoIMC : Form
    {
        public CalculoIMC()
        {
            InitializeComponent();
        }

        string classificar;
        private float CalculoImc(float altura, float peso)
        {
            float calc = ((peso / (altura * altura)) * 10000);
            return calc;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float peso = float.Parse(txtPeso.Text);
                float altura = float.Parse(txtAltura.Text);
                double imc = Math.Round((double)CalculoImc(altura, peso), 2);

                if (imc < 20 )
                    classificar = "Abaixo do Peso";
                if (imc >= 20 && imc <= 25)
                    classificar = "Peso Ideal";
                if (imc > 25 && imc <= 30)
                    classificar = "Sobrepeso";
                if (imc > 30 && imc <= 35)
                    classificar = "Obesidade Leve";
                if (imc > 35 && imc <= 40)
                    classificar = "Obesidade Mederada";
                if (imc > 40 && imc <= 50)
                    classificar = "Obesidade Mórbida";
                if (imc > 50)
                    classificar = "Super Obesidade";

                lbReasultado.Text = imc.ToString() + "\n" + classificar;
            }
            catch
            {
                MessageBox.Show("Digite apenas números e não deixe campos em branco!");
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            lbReasultado.Text = "";
        }
    }
}
