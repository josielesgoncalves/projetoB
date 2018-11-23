using ProjetoB.Model;
using ProjetoB.Util;
using System;
using System.Windows.Forms;

namespace ProjetoB
{
    public partial class Register : Form
    {
        private User user;
        private Validation validation;
        public Register()
        {
            InitializeComponent();
            
            user = new User();
            validation = new Validation();
        }
                
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar todos os campos?", "Pergunta",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LimparCampos();
            }

        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbEmail.Clear();
            tbCpf.Clear();
            tbRg.Clear();
            tbSenha.Clear();
            tbCSenha.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validation.ValidaNome(tbNome.Text) && 
                validation.ValidaEmail(tbEmail.Text) &&
                validation.ValidaCPF(tbCpf.Text) &&
                validation.ValidaRG(tbRg.Text) &&
                validation.ValidaSenha(tbSenha.Text, tbNome.Text, tbCpf.Text))
            {
                if (!tbSenha.Text.Equals(String.Empty))
                    if (validation.ConfirmaSenha(tbSenha.Text, tbCSenha.Text))
                    {
                        User user = new User();
                        user.Nome = tbNome.Text;
                        user.Cpf = tbCpf.Text;
                        user.Rg = tbRg.Text;
                        user.Email = tbEmail.Text;
                        user.Senha = validation.CriptografarSenha(tbSenha.Text, 4);
                        
                        try
                        {
                            if (!BD.Cadastrado(user.Cpf))
                            {
                                BD.InserirUsuario(user);
                                this.Close();
                                new Login().Show();                                
                            }
                            else
                            {
                                MessageBox.Show("Usuario já cadastrado!");
                                LimparCampos();
                            }
                        }
                        catch { MessageBox.Show("Problema na conexão", "ERROR", MessageBoxButtons.OK); }
                    }            
            }
            else
            {
                LimparCampos();
                MessageBox.Show("Preencha os campos novamente!");
            }
        }
     
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult voltar = MessageBox.Show("Deseja realmente voltar a tela de login?", "Voltar", MessageBoxButtons.YesNo);
            if (voltar == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();                
            }           
        }
           
    }
}
