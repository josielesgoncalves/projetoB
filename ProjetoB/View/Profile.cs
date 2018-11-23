using ProjetoB.Model;
using ProjetoB.Util;
using ProjetoB.View;
using System;
using System.Windows.Forms;

namespace ProjetoB
{
    public partial class Profile : Form
    {
        private User user;
        private Validation validation;

        public Profile(User _user)
        {
            validation = new Validation();
            user = _user;         

            InitializeComponent();

            tbCpf.Text = user.Cpf;
            tbEmail.Text = user.Email;
            tbNome.Text = user.Nome;
            tbRg.Text = user.Rg;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validation.ValidaNome(tbNome.Text) &&
                validation.ValidaEmail(tbEmail.Text) &&
                validation.ValidaCPF(tbCpf.Text) &&
                validation.ValidaRG(tbRg.Text))                
            {
                User update = new User();
                update.Nome = tbNome.Text;
                update.Cpf = tbCpf.Text;
                update.Rg = tbRg.Text;
                update.Email = tbEmail.Text;

                try
                {
                    if (!BD.Cadastrado(update.Cpf))
                    {
                        BD.AtualizarUsuario(update, user.Cpf);
                        new Login().Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Existe outro cadastro com esse cpf");
                        LimparCampos();
                    }
                }
                catch { MessageBox.Show("Problema na conexão", "ERROR", MessageBoxButtons.OK); }
            }
            else
            {
                LimparCampos();
                MessageBox.Show("Preencha os campos novamente!");
            }
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbEmail.Clear();
            tbCpf.Clear();
            tbRg.Clear();            
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            new AtualizaSenha().Show();            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente excluir seu perfil?", "EXCLUIR", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                BD.ExcluirUsuario(user);
                this.MdiParent.Close();                
            }

            MessageBox.Show("A conta foi excluida com sucesso!", "ALERTA");

            new Login().Show();
        }
    }
}
