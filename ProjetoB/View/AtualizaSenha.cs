using ProjetoB.Model;
using ProjetoB.Util;
using System;
using System.Windows.Forms;

namespace ProjetoB.View
{
    public partial class AtualizaSenha : Form
    {
        private Validation validation;
        public AtualizaSenha()
        {
            validation = new Validation();
            InitializeComponent();
        }

        private bool validaSenha(User user)
        {
            bool isValid = false;
            try
            {
                string senha = tbSenha.Text;
                if (senha.Length > 11)
                {
                    MessageBox.Show("A senha deve possuir um máximo de 11 caracteres");
                    tbSenha.Clear();
                }
                else if (senha.Length < 7)
                {
                    MessageBox.Show("A senha deve possuir um mínino de 7 caracteres");
                    tbSenha.Clear();
                }
                else
                {
                    if (!validation.IsValidPassword(senha))
                    {
                        MessageBox.Show("A senha possui caracteres invalidos");
                    }
                    else
                    {   
                        string cpf = tbCPF.Text;
                        string strength = validation.PasswordStrength(senha, user.Nome, user.Cpf);
                        isValid = true;

                        if (strength.Equals("Muito Fraca"))
                        {
                            MessageBox.Show("Sua senha é MUITO FRACA. Favor, digite outra senha");
                            tbSenha.Clear();
                            tbConfirmaSenha.Clear();
                            isValid = false;
                        }
                        else
                            MessageBox.Show("Sua senha é " + strength);
                    }
                }
            }
            catch { MessageBox.Show("O campo de senha é obrigatório"); }

            return isValid;

        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;
            string senha = tbSenha.Text;
            string confirmaSenha = tbConfirmaSenha.Text;

            try
            {
                if (BD.Cadastrado(cpf))
                {
                    User user = BD.BuscarUsuario(cpf);
                    if (validaSenha(user))
                    {
                        if (senha.Equals(confirmaSenha))
                        {
                            senha = validation.CriptografarSenha(tbSenha.Text, 4);
                            BD.AtualizarSenha(user, senha);
                        }
                        
                        else
                            MessageBox.Show("As senhas não são iguais");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado");
                }

                MessageBox.Show("Senha atualizada com sucesso!!");
                new Login().Show();
                this.Dispose();
            }
            catch { }        
        }
    }
}
