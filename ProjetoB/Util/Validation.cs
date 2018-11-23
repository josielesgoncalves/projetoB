using System;
using System.Windows.Forms;

namespace ProjetoB.Util
{
    public class Validation
    {
        public Validation() { }
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {
            bool isValid = true;
            int contNum = 0, contChar = 0;
            
            if (password.Length > 7 && password.Length < 11) {

                for (int i = 0; i < password.Length; i++)
                {
                    if (i > 1 && password[i] == password[i - 1] && password[i] == password[i - 2])
                    {
                        isValid = false;
                        break;
                    }
                        
                    for (int j = 32; j <= 47; j++)
                    {
                        string specialChar = char.ConvertFromUtf32(j);
                        if (password[i].Equals(specialChar)) {
                            isValid = false;
                            break;
                        }
                    }
                    for (int j = 58; j <= 64; j++)
                    {
                        string specialChar = char.ConvertFromUtf32(j);
                        if (password[i].Equals(specialChar)) {
                            isValid = false;
                            break;
                        }
                    }
                    for (int j = 91; j <= 96; j++)
                    {
                        string specialChar = char.ConvertFromUtf32(j);
                        if (password[i].Equals(specialChar)) {
                            isValid = false;
                            break;
                        }
                    }
                    for (int j = 123; j <= 126; j++)
                    {
                        string specialChar = char.ConvertFromUtf32(j);
                        if (password[i].Equals(specialChar)) {
                            isValid = false;
                            break;
                        }
                    }
                    for (int j = 48; j <= 57; j++)
                    {
                        string num = char.ConvertFromUtf32(j);
                        if (password[i].Equals(num)) contNum++;
                    }
                    for (int j = 65; j <= 90; j++)
                    {
                        string chrUpp = char.ConvertFromUtf32(j);
                        if (password[i].Equals(chrUpp)) contChar++;
                    }
                    for (int j = 97; j <= 122; j++)
                    {
                        string chrLow = char.ConvertFromUtf32(j);
                        if (password[i].Equals(chrLow)) contChar++;
                    }
                }

                if (contChar >= 2 || contNum >= 3)
                    isValid = true;
            }           
            
            return isValid;
        } 

        private int PasswordValue(string password, string name, string cpf)
        {
            int strength = 10;
            string[] word = name.Split(' ');            
            if (password.Contains(cpf) || password.Contains(word[0])) { strength -= 2; }

            string inicialsName = "";
            foreach (string s in word)
                inicialsName += s[0];

            if (password.Contains(inicialsName)) { strength -= 3; }

            int contNum = 0, contChar = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (i > 2) {
                    for (int j = 48; j <= 57; j++)
                    {
                        string num = char.ConvertFromUtf32(j);
                        if (password[i].Equals(num)) contNum++;
                    }
                    for (int j = 65; j <= 90; j++)
                    {
                        string chrUpp = char.ConvertFromUtf32(j);
                        if (password[i].Equals(chrUpp)) contChar++;
                    }
                    for (int j = 97; j <= 122; j++)
                    {
                        string chrLow = char.ConvertFromUtf32(j);
                        if (password[i].Equals(chrLow)) contChar++;
                    }

                    if (contNum <= 2 || contChar <= 3) strength -= 1;
                }
            }



            return strength;
        }

        public string PasswordStrength(string password, string name, string cpf)
        {
            int value = PasswordValue(password, name, cpf);
            string strength = "";

            switch (value)
            {
                case 10:
                    strength = "Muito Forte";
                    break;
                case 9:
                    strength = "Muito Forte";
                    break;
                case 8:
                    strength = "Forte";
                    break;
                case 7:
                    strength = "Forte";
                    break;
                case 6:
                    strength = "Razoavel";
                    break;
                case 5:
                    strength = "Razoavel";
                    break;
                case 4:
                    strength = "Fraca";
                    break;
                case 3:
                    strength = "Fraca";
                    break;
                default:
                    strength = "Muito Fraca";
                    break;
            }

            return strength;
        }

        public bool ValidaEmail(string email)
        {
            bool isValid = false;
            try
            {   
                if (!this.IsValidEmail(email))
                {
                    MessageBox.Show("Favor, preencha um email válido!");                    
                }
                else
                {   
                    isValid = true;
                }

            }
            catch { MessageBox.Show("Preencha o campo de email"); }

            return isValid;
        }
        public bool ValidaCPF(string cpf)
        {
            bool isValid = false;
            try
            {   
                if (cpf.Length != 11)
                {
                    MessageBox.Show("CPF contém apenas 11 dígitos");             
                }
                else
                {
                    isValid = true;
                    foreach (char c in cpf)
                    {
                        if (!Char.IsDigit(c))
                        {
                            isValid = false;
                            MessageBox.Show("O CPF deve conter apenas números");
                            break;
                        }
                    }
                }
            }
            catch { MessageBox.Show("O campo de cpf deve ser preenchido"); }

            return isValid;

        }
        public bool ValidaRG(string rg)
        {
            bool isValid = false;
            try
            {
                if (rg.Length < 9)
                {
                    MessageBox.Show("RG contém a partir de 9 dígitos");             
                }
                else
                {
                    isValid = true;
                    foreach (char c in rg)
                    {
                        if (!Char.IsDigit(c))
                        {
                            isValid = false;
                            MessageBox.Show("O RG deve conter apenas números");                            
                            break;
                        }
                    }
                }
            }
            catch { MessageBox.Show("O campo de rg deve ser preenchido"); }

            return isValid;

        }
        public bool ValidaNome(string nome)
        {
            bool isValid = false;
            if (nome.Length > 30)
            {
                MessageBox.Show("O campo deve possuir no máximo 30 caracteres");            
            }
            else
            {   
                isValid = true;
            }

            return isValid;
        }
        public bool ValidaSenha(string senha, string nome, string cpf)
        {
            bool isValid = false;
            try
            {   
                if (senha.Length > 11)
                {
                    MessageBox.Show("A senha deve possuir um máximo de 11 caracteres");             
                }
                else if (senha.Length < 7)
                {
                    MessageBox.Show("A senha deve possuir um mínino de 7 caracteres");                    
                }
                else
                {
                    if (!this.IsValidPassword(senha))
                    {
                        MessageBox.Show("A senha possui caracteres invalidos");
                    }
                    else
                    {
                        string strength = this.PasswordStrength(senha, nome, cpf);
                        isValid = true;

                        if (strength.Equals("Muito Fraca"))
                        {
                            MessageBox.Show("Sua senha é MUITO FRACA. Favor, digite outra senha");
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
        public bool ConfirmaSenha(string senha, string confirmeSenha)
        {
            bool isValid = false;
            try
            {   if (!confirmeSenha.Equals(senha))
                {
                    MessageBox.Show("As senhas não são iguais. Favor, confirme sua senha");
                }
                else
                    isValid = true;

            }
            catch { MessageBox.Show("Verifique se os campos de senha estão preenchidos!"); }

            return isValid;
        }

        public string CriptografarSenha(string password, int cifra)
        {
            int letra;
            string senha = "";
            password = password.ToUpper();
            for (int i = 0; i < password.Length; i++)
            {
                letra = Convert.ToInt32(password[i]);
                letra = DefinirASCIIExtra(letra);
                letra += cifra;
                letra = CriptografiaDasVogais(letra);
                if (letra > 90 && letra <= 100)
                {
                    letra = CriptografiaASCIIExtra(letra);
                }
                if (letra > 100)
                {
                    letra -= 36;
                    letra = CriptografiaDasVogais(letra);
                    letra = DefinirASCIIExtra(letra);
                }
                senha += Convert.ToChar(letra);
            }

            return senha;
        }

        private int DefinirASCIIExtra(int numeroASCII)
        {
            switch (numeroASCII)
            {
                case 32:
                    numeroASCII = 90;
                    break;
                case 48:
                    numeroASCII = 91;
                    break;
                case 49:
                    numeroASCII = 92;
                    break;
                case 50:
                    numeroASCII = 93;
                    break;
                case 51:
                    numeroASCII = 94;
                    break;
                case 52:
                    numeroASCII = 95;
                    break;
                case 53:
                    numeroASCII = 96;
                    break;
                case 54:
                    numeroASCII = 97;
                    break;
                case 55:
                    numeroASCII = 98;
                    break;
                case 56:
                    numeroASCII = 99;
                    break;
                case 57:
                    numeroASCII = 100;
                    break;
            }
            return numeroASCII;
        }

        private int CriptografiaDasVogais(int letter)
        {
            switch (letter)
            {
                case 65:
                    letter = 42;
                    break;
                case 69:
                    letter = 35;
                    break;
                case 73:
                    letter = 43;
                    break;
                case 79:
                    letter = 45;
                    break;
                case 85:
                    letter = 36;
                    break;
            }

            return letter;
        }

        private int CriptografiaASCIIExtra(int letter)
        {
            switch (letter)
            {
                case 90:
                    letter = 32;
                    break;
                case 91:
                    letter = 48;
                    break;
                case 92:
                    letter = 49;
                    break;
                case 93:
                    letter = 50;
                    break;
                case 94:
                    letter = 51;
                    break;
                case 95:
                    letter = 52;
                    break;
                case 96:
                    letter = 53;
                    break;
                case 97:
                    letter = 54;
                    break;
                case 98:
                    letter = 55;
                    break;
                case 99:
                    letter = 56;
                    break;
                case 100:
                    letter = 57;
                    break;
            }
            return letter;
        }
    }
}




    

