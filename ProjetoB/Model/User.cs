using System;


namespace ProjetoB.Model
{
    public class User
    {
        public User() { }

        public User(string nome, string email, string cpf, 
            string rg, Tipo status, Role perfil, String dataInclusao,
            String dataExclusao, string senha, string dataUltimaSenha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Status = status;
            this.Perfil = perfil;
            this.DataInclusao = dataInclusao;
            this.DataExclusao = dataExclusao;
            this.Senha = senha;
            this.DataUltimaSenha = dataUltimaSenha;
        }

        private string nome;
        private string email;
        private string senha;
        private string cpf;
        private string rg;
        private Tipo status;
        private Role perfil;
        private String dataInclusao;
        private String dataExclusao;
        private String dataUltimaSenha;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public Tipo Status { get => status; set => status = value; }
        public Role Perfil { get => perfil; set => perfil = value; }
        public String DataInclusao { get => dataInclusao; set => dataInclusao = value; }
        public String DataExclusao { get => dataExclusao; set => dataExclusao = value; }
        public string DataUltimaSenha { get => dataUltimaSenha; set => dataUltimaSenha = value; }

        public enum Role
        {
            ADMIN,
            USER,
        }

        public enum Tipo
        {
            NORMAL,
            BLOQUEADO,
            EXCLUIDO,
        }
    }
}
