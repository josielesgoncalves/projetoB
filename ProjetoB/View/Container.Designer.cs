namespace ProjetoB.View
{
    partial class Container
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoIMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoCaloriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloqueadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluídosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.calculoIMCToolStripMenuItem,
            this.cálculoCaloriasToolStripMenuItem,
            this.sobMedidaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.sairToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            resources.ApplyResources(this.inicioToolStripMenuItem, "inicioToolStripMenuItem");
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            resources.ApplyResources(this.perfilToolStripMenuItem, "perfilToolStripMenuItem");
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // calculoIMCToolStripMenuItem
            // 
            this.calculoIMCToolStripMenuItem.Name = "calculoIMCToolStripMenuItem";
            resources.ApplyResources(this.calculoIMCToolStripMenuItem, "calculoIMCToolStripMenuItem");
            this.calculoIMCToolStripMenuItem.Click += new System.EventHandler(this.calculoIMCToolStripMenuItem_Click);
            // 
            // cálculoCaloriasToolStripMenuItem
            // 
            this.cálculoCaloriasToolStripMenuItem.Name = "cálculoCaloriasToolStripMenuItem";
            resources.ApplyResources(this.cálculoCaloriasToolStripMenuItem, "cálculoCaloriasToolStripMenuItem");
            this.cálculoCaloriasToolStripMenuItem.Click += new System.EventHandler(this.cálculoCaloriasToolStripMenuItem_Click);
            // 
            // sobMedidaToolStripMenuItem
            // 
            this.sobMedidaToolStripMenuItem.Name = "sobMedidaToolStripMenuItem";
            resources.ApplyResources(this.sobMedidaToolStripMenuItem, "sobMedidaToolStripMenuItem");
            this.sobMedidaToolStripMenuItem.Click += new System.EventHandler(this.sobMedidaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloqueadosToolStripMenuItem,
            this.excluídosToolStripMenuItem,
            this.normalToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            resources.ApplyResources(this.usuariosToolStripMenuItem, "usuariosToolStripMenuItem");
            // 
            // bloqueadosToolStripMenuItem
            // 
            this.bloqueadosToolStripMenuItem.Name = "bloqueadosToolStripMenuItem";
            resources.ApplyResources(this.bloqueadosToolStripMenuItem, "bloqueadosToolStripMenuItem");
            this.bloqueadosToolStripMenuItem.Click += new System.EventHandler(this.bloqueadosToolStripMenuItem_Click);
            // 
            // excluídosToolStripMenuItem
            // 
            this.excluídosToolStripMenuItem.Name = "excluídosToolStripMenuItem";
            resources.ApplyResources(this.excluídosToolStripMenuItem, "excluídosToolStripMenuItem");
            this.excluídosToolStripMenuItem.Click += new System.EventHandler(this.excluídosToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            resources.ApplyResources(this.normalToolStripMenuItem, "normalToolStripMenuItem");
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Container
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Container";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Container_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoIMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoCaloriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloqueadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluídosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobMedidaToolStripMenuItem;
    }
}