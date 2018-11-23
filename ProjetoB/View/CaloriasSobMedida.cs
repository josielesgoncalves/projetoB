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

    public partial class CaloriasSobMedida : Form
    {
        public CaloriasSobMedida()
        {
            InitializeComponent();
            cboFAF.SelectedIndex = 0;
            rbnDesabilitado.Checked = true;
            rbnFemino.Checked = true;
        }

        private bool fracionado;
        private bool sexo;
        private double peso;
        private double altura;
        private int idade;
        private double tbm;
        private double caloriaTotal;

        public void Menssagens()
        {
            if (txtAltura.Text.Equals(""))
                MessageBox.Show("Erro: O campo altura deve ser informado");
            if (txtPeso.Text.Equals(""))
                MessageBox.Show("Erro: O campo peso deve ser informado");
            if (txtIdade.Text.Equals(""))
                MessageBox.Show("Erro: O campo idade deve ser informado");
        }

        public bool VerificarCamposVazios()
        {
            bool verificar = true;

            if (txtAltura.Text.Equals("") || txtPeso.Text.Equals("") || txtIdade.Text.Equals(""))
                verificar = false;

            return verificar;
        }

        public double TBM(double peso, double altura, int idade, bool sexo)
        {
            double tbm;
            if (sexo == true)
                tbm = 88.36 + (13.4 * peso) + (4.8 * altura) - (5.7 * idade);
            else
                tbm = 447.6 + (9.2 * peso) + (3.1 * altura) - (4.3 * idade);

            return tbm;
        }

        public double CaloriaTotal(double tbm, ComboBox fator, bool fracionada)
        {
            double fatorAtv = 0;
            double caloriaTotal = 0;

            switch (fator.SelectedIndex)
            {
                case 0:
                    fatorAtv = 1;
                    break;
                case 1:
                    fatorAtv = 1.2;
                    break;
                case 2:
                    fatorAtv = 1.375;
                    break;
                case 3:
                    fatorAtv = 1.55;
                    break;
                case 4:
                    fatorAtv = 1.725;
                    break;
                case 5:
                    fatorAtv = 1.9;
                    break;
            }

            if(fracionada == true)
            {
                caloriaTotal = (tbm * fatorAtv) + (tbm * 0.1);
                return caloriaTotal;
            }
            else
            {
                caloriaTotal = tbm * fatorAtv;
                return caloriaTotal;
            }
        }

        public double Parse(TextBox valor)
        {
            double parse = double.Parse(valor.Text);
            return parse;
        }

    private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(VerificarCamposVazios() == true)
            {
                this.fracionado = rbnHabilitado.Checked == true ? true : false;
                this.sexo = rbnMasculino.Checked == true ? true : false;

                this.tbm = Math.Round(TBM(this.peso, this.altura, this.idade, this.sexo));
                this.caloriaTotal = Math.Round(CaloriaTotal(this.tbm, cboFAF, this.fracionado));

                lblResultado.Text = "\n Você deve consumir: " + caloriaTotal + " cal";
            }
            else
            {
                Menssagens();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            rbnFemino.Checked = true;
            rbnDesabilitado.Checked = true;
            lblResultado.Text = "";
            cboFAF.SelectedIndex = 0;
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIdade.Text != "")
                {
                    this.idade = (int)Parse(txtIdade);

                    if (idade < 1 || idade > 120)
                        MessageBox.Show("Erro: O campo idade deve ser preenchido com um valor entre 1 e 120");
                }
            }
            catch
            {
                MessageBox.Show("Erro: O campo idade deve ser preenchido com um valor entre 1 e 120" );
            }            
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                if(txtAltura.Text.Length > 2 && txtAltura.Text != "")
                {
                    this.altura = Parse(txtAltura);

                    if (altura < 30 || altura > 250)
                        MessageBox.Show("Erro: O campo Altura deve ser preenchido com um valor entre 30 e 250");
                } 
            }
            catch
            {
                MessageBox.Show("Erro: O campo Altura deve ser preenchido com um valor entre 30 e 250");
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if(txtPeso.Text != "")
            {
                try
                {
                    this.peso = Parse(txtPeso);

                    if (peso < 1 || peso > 400)
                        MessageBox.Show("Erro: O campo peso deve ser preenchido com um valor entre 1 e 400");
                }
                catch
                {
                    MessageBox.Show("Erro: O campo peso deve ser preenchido com um valor entre 1 e 400");
                }
            }
        }
    }
}
