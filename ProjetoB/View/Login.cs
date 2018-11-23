using ProjetoB.Model;
using ProjetoB.Util;
using ProjetoB.View;
using System;
using System.Windows.Forms;


namespace ProjetoB
{
    public partial class Login : Form
    {

        private User user;
        private Validation validation;
        public Login()
        {
            validation = new Validation();
            InitializeComponent();            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {   
            string login = txtCpf.Text;
            string senha = validation.CriptografarSenha(txtSenha.Text, 4);

            if (BD.Cadastrado(login))
            {
                user = BD.BuscarUsuario(login);                
                if (senha.Equals(user.Senha))
                {
                    if (user.Status == User.Tipo.NORMAL)
                    {
                        new Container(user).Show();
                        this.Hide();
                    }
                    else if (user.Status == User.Tipo.BLOQUEADO)
                    {
                        MessageBox.Show("Usuario bloqueado");
                    }
                    else
                        MessageBox.Show("Usuario excluido");
                }
                else
                {
                    MessageBox.Show("A senha está incorreta");
                }
            }
            else
                MessageBox.Show("Usuario não encontrado");
        }

        private void lblinkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void linkLabelEsqueceu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AtualizaSenha().Show();
            this.Hide();
        }
    }
}
