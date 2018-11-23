using ProjetoB.Model;
using System;
using System.Windows.Forms;
using ProjetoB.Util;
using System.Collections.Generic;

namespace ProjetoB.View
{
    public partial class Container : Form
    {
        private User user;
        public Container(User _user)
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.Cascade);
            user = _user;

            if (user.Perfil == User.Role.USER)
            {
                usuariosToolStripMenuItem.Visible = false;
            }
        }

        private void calculoIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();
            CalculoIMC view = new CalculoIMC();
            view.MdiParent = this;
            view.Show();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();            
            UsuariosNormais view = new UsuariosNormais();
            view.MdiParent = this;
            view.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();
            Home view = new Home();
            view.MdiParent = this;
            view.Show();

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();
            Profile view = new Profile(user);
            view.MdiParent = this;
            view.Show();

        }

        private void cálculoCaloriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();
            CalorieControl view = new CalorieControl();
            view.MdiParent = this;
            view.Show();
        }

        private void sobMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();
            CaloriasSobMedida view = new CaloriasSobMedida();
            view.MdiParent = this;
            view.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente fechar o programa?", "SAIR", MessageBoxButtons.YesNo);
            if (sair == DialogResult.Yes)
            {
                this.Close();                
            }
        }    

        private void fechar()
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();           

        }

        private void bloqueadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();            
            UsuariosBloqueados view = new UsuariosBloqueados();
            view.MdiParent = this;
            view.Show();

        }

        private void excluídosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fechar();            
            UsuariosExcluidos view = new UsuariosExcluidos();
            view.MdiParent = this;
            view.Show();

        }

        private void Container_Load(object sender, EventArgs e)
        {
            this.fechar();
            Home view = new Home();
            view.MdiParent = this;
            view.Show();
        }
    }

   
}
