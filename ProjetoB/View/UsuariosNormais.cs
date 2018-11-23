using ProjetoB.Model;
using ProjetoB.Util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoB.View
{
    public partial class UsuariosNormais : Form
    {
        private List<User> users;
        public UsuariosNormais()
        {   
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            users = BD.BuscarUsuariosAtivos();

            lvUsuarios.View = System.Windows.Forms.View.Details;
            lvUsuarios.Columns.Add("Nome", 200);
            lvUsuarios.Columns.Add("CPF", 100);
            lvUsuarios.Columns.Add("RG", 100);
            lvUsuarios.Columns.Add("PERFIL", 100);
            lvUsuarios.Columns.Add("STATUS", 100);
            lvUsuarios.Columns.Add("DATA INCLUSÃO", 100);

            CarregarListView();
        }

        private void CarregarListView()
        {
            lvUsuarios.Items.Clear();
            foreach (User user in users)
            {
                
                ListViewItem item = new ListViewItem(user.Nome);
                item.SubItems.Add(user.Cpf);
                item.SubItems.Add(user.Rg);
                item.SubItems.Add(user.Perfil.ToString());
                item.SubItems.Add(user.Status.ToString());
                item.SubItems.Add(user.DataInclusao);
                lvUsuarios.Items.Add(item);
            }
        }

        private void btnBloquear_Click(object sender, System.EventArgs e)
        {
            if(users.Count > 0)
            {
                foreach (ListViewItem i in lvUsuarios.SelectedItems)
                {
                    User user = users[i.Index];
                    BD.BloquearUsuario(user);
                    users.Remove(user);
                }
            }
            this.CarregarListView();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {
            if (users.Count > 0)
            {
                foreach (ListViewItem i in lvUsuarios.SelectedItems)
                {
                    User user = users[i.Index];
                    BD.ExcluirUsuario(user);
                    users.Remove(user);
                }
            }
            this.CarregarListView();

        }
    }
}
