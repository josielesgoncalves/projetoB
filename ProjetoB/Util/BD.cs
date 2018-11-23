using ProjetoB.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;
using static ProjetoB.Model.User;

namespace ProjetoB.Util
{
    public static class BD
    {
        private static OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Josiele\Faculdade\PUC\2018.2\Projeto B\ProjetoB\Access\projetoB.accdb");

        public static OleDbConnection CONNECTION
        {
            get
            {   
                return connection;
            }          
        }

        public static bool Cadastrado(string login)
        {
            bool isCadastrado = false;
            try
            {                
                String sql = "SELECT * FROM USUARIO WHERE EMAIL = '" + login + "' OR CPF = '" + login + "'";
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    isCadastrado = true;                   

                CONNECTION.Close();
                
            } catch (Exception e){ MessageBox.Show(e.Message); }            
            return isCadastrado;
        }

        public static void InserirUsuario(User user)
        {   
            try
            {   
                string dateNow = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);

                String sql = "INSERT INTO USUARIO(EMAIL, CPF, NOME, RG, SENHA, DATA_INCLUSAO, DATA_EXCLUSAO, STATUS, PERFIL, DATA_SENHA)" +
                    "VALUES('" + user.Email + "' ,'" + user.Cpf + "','" + user.Nome + "' ,'" + user.Rg + "' ,'" + 
                    user.Senha + "' ," + "" + "'" + dateNow + "'" + "," + "" + "null" + "," +
                    Tipo.NORMAL.GetHashCode() + "," + Role.USER.GetHashCode() + ", '"  + dateNow +  "')";

                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso");

                CONNECTION.Close();
            }
            catch (Exception e){ MessageBox.Show(e.Message); }

        }

        public static void AtivarUsuario(User user)
        {
            try
            {
                String sql = "UPDATE USUARIO" +
                             " SET STATUS = " + Tipo.NORMAL.GetHashCode() + "," +
                             " DATA_EXCLUSAO = ''" +
                             " WHERE CPF = '" + user.Cpf + "'";
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                command.ExecuteNonQuery();
                CONNECTION.Close();

            }
            catch { MessageBox.Show("Erro ao atualizar usuario"); }
        }

        public static void ExcluirUsuario(User user)
        {
            try
            {
                string dateNow = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);
                String sql = "UPDATE USUARIO" +
                             " SET STATUS = " + Tipo.EXCLUIDO.GetHashCode() + "," +
                             " DATA_EXCLUSAO = '" + dateNow + "'" +
                              "WHERE CPF = '" + user.Cpf + "'";
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                command.ExecuteNonQuery();
                CONNECTION.Close();
            }
            catch { MessageBox.Show("Erro ao atualizar usuario"); }

        }

        public static void BloquearUsuario(User user)
        {
            try
            {
                String sql = "UPDATE USUARIO" +
                             " SET STATUS = " + Tipo.BLOQUEADO.GetHashCode() +
                             " WHERE CPF = '" + user.Cpf + "'";
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                command.ExecuteNonQuery();
                CONNECTION.Close();
            }
            catch { MessageBox.Show("Erro ao atualizar usuario"); }

        }

        public static User BuscarUsuario(string login)
        {
            //TODO: verificar se senha esta correta: descripitografar, se não estiver correta, avisar

            User user = null;                 
            try
            {
                String sql = "SELECT * FROM USUARIO WHERE EMAIL = '" + login + "' OR CPF = '" + login + "'";
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                using (OleDbDataReader reader = command.ExecuteReader())
                {                          
                    while (reader.Read())
                    {
                        string nome = reader["NOME"].ToString();
                        string email = reader["EMAIL"].ToString();
                        string cpf = reader["CPF"].ToString();
                        string rg = reader["RG"].ToString();   
                        string senha = reader["SENHA"].ToString();
                        Role perfil = (Role)reader["PERFIL"];
                        Tipo status = (Tipo)reader["STATUS"];

                        string dataInclusao = reader["DATA_INCLUSAO"].ToString();
                        String dataExclusao = reader["DATA_EXCLUSAO"].ToString();
                        string dataSenha= reader["DATA_SENHA"].ToString();

                        user = new User(nome, email, cpf, rg, status, perfil, dataInclusao, dataExclusao, senha, dataSenha);
                    }                                    
                }
                CONNECTION.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return user;
        }

        public static List<User> BuscarUsuariosBloqueados()
        {
            List<User> usuarios = new List<User>();
            try
            {
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM USUARIO WHERE STATUS = " + Tipo.BLOQUEADO.GetHashCode(), CONNECTION);

                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nome = reader["NOME"].ToString();
                    string email = reader["EMAIL"].ToString();
                    string cpf = reader["CPF"].ToString();
                    string rg = reader["RG"].ToString();
                    string senha = reader["SENHA"].ToString();
                    string dataInclusao = reader["DATA_INCLUSAO"].ToString();
                    String dataExclusao = reader["DATA_EXCLUSAO"].ToString();
                    string dataSenha = reader["DATA_SENHA"].ToString();
                    Role perfil = (Role)reader["PERFIL"];
                    Tipo status = (Tipo)reader["STATUS"];


                    User user = new User(nome, email, cpf, rg, status, perfil, dataInclusao, dataExclusao, senha, dataSenha);
                    usuarios.Add(user);
                }
                CONNECTION.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return usuarios;
        }

        public static List<User> BuscarUsuariosExcluidos()
        {
            List<User> usuarios = new List<User>();
            try
            {
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM USUARIO WHERE STATUS = " + Tipo.EXCLUIDO.GetHashCode(), CONNECTION);

                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nome = reader["NOME"].ToString();
                    string email = reader["EMAIL"].ToString();
                    string cpf = reader["CPF"].ToString();
                    string rg = reader["RG"].ToString();
                    string senha = reader["SENHA"].ToString();
                    string dataInclusao = reader["DATA_INCLUSAO"].ToString();
                    String dataExclusao = reader["DATA_EXCLUSAO"].ToString();
                    string dataSenha = reader["DATA_SENHA"].ToString();
                    Role perfil = (Role)reader["PERFIL"];
                    Tipo status = (Tipo)reader["STATUS"];


                    User user = new User(nome, email, cpf, rg, status, perfil, dataInclusao, dataExclusao, senha, dataSenha);
                    usuarios.Add(user);
                }
                CONNECTION.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return usuarios;
        }
        
        public static List<User> BuscarUsuariosAtivos()
        {
            List<User> usuarios = new List<User>();
            try
            {
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM USUARIO WHERE STATUS = " + Tipo.NORMAL.GetHashCode(), CONNECTION);

                command.ExecuteNonQuery();
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string nome = reader["NOME"].ToString();
                    string email = reader["EMAIL"].ToString();
                    string cpf = reader["CPF"].ToString();
                    string rg = reader["RG"].ToString();
                    string senha = reader["SENHA"].ToString();
                    string dataInclusao = reader["DATA_INCLUSAO"].ToString();
                    String dataExclusao = reader["DATA_EXCLUSAO"].ToString();
                    string dataSenha = reader["DATA_SENHA"].ToString();
                    Role perfil = (Role)reader["PERFIL"];
                    Tipo status = (Tipo)reader["STATUS"];


                    User user = new User(nome, email, cpf, rg, status, perfil, dataInclusao, dataExclusao, senha, dataSenha);
                    usuarios.Add(user);                  
                }

                CONNECTION.Close();
            }
            catch (Exception e){ MessageBox.Show(e.Message); }
            
            return usuarios;
        }
       
        public static void AtualizarSenha(User user, string senha)
        {
            try
            {
                string dateNow = DateTime.Now.ToString("dd/MM/yyyy H:mm:ss", CultureInfo.InvariantCulture);

                String sql = "UPDATE USUARIO" +
                             " SET SENHA = '" + senha + "'" +
                             " DATA_SENHA = '" + dateNow + "'" +
                             " WHERE CPF = '" + user.Cpf + "'";
                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                command.ExecuteNonQuery();
                CONNECTION.Close();

            }
            catch { MessageBox.Show("Erro ao atualizar senha"); }
        }

        public static void AtualizarUsuario(User user, string cpf)
        {
            try
            {
                String sql = "UPDATE USUARIO" +
                             "SET NOME = '" + user.Nome + "'," +
                             "RG = '" + user.Rg + "'," +
                             "EMAIL = '" + user.Email + "'," +
                             "CPF = '" + user.Cpf + "'" +
                             "WHERE CPF = '" + cpf + "'";

                CONNECTION.Open();

                OleDbCommand command = new OleDbCommand(sql, CONNECTION);

                command.ExecuteNonQuery();
                MessageBox.Show("Cadastro feito com sucesso");

                CONNECTION.Close();

            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
