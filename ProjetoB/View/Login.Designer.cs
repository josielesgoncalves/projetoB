namespace ProjetoB
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblinkCadastro = new System.Windows.Forms.LinkLabel();
            this.lbSuperFitness = new System.Windows.Forms.Label();
            this.linkLabelEsqueceu = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnEntrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(78, 422);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(203, 35);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(148, 196);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(48, 23);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSenha.Location = new System.Drawing.Point(78, 326);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(203, 35);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "senha";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCpf.Location = new System.Drawing.Point(78, 271);
            this.txtCpf.Multiline = true;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCpf.Size = new System.Drawing.Size(203, 35);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.Text = "CPF";
            // 
            // lblinkCadastro
            // 
            this.lblinkCadastro.AutoSize = true;
            this.lblinkCadastro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinkCadastro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblinkCadastro.LinkColor = System.Drawing.Color.Black;
            this.lblinkCadastro.Location = new System.Drawing.Point(122, 473);
            this.lblinkCadastro.Name = "lblinkCadastro";
            this.lblinkCadastro.Size = new System.Drawing.Size(122, 18);
            this.lblinkCadastro.TabIndex = 3;
            this.lblinkCadastro.TabStop = true;
            this.lblinkCadastro.Text = "Não é cadastrado?";
            this.lblinkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblinkCadastro_LinkClicked);
            // 
            // lbSuperFitness
            // 
            this.lbSuperFitness.AutoSize = true;
            this.lbSuperFitness.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuperFitness.Location = new System.Drawing.Point(61, 101);
            this.lbSuperFitness.Name = "lbSuperFitness";
            this.lbSuperFitness.Size = new System.Drawing.Size(229, 45);
            this.lbSuperFitness.TabIndex = 7;
            this.lbSuperFitness.Text = "Super Fitness";
            // 
            // linkLabelEsqueceu
            // 
            this.linkLabelEsqueceu.AutoSize = true;
            this.linkLabelEsqueceu.Location = new System.Drawing.Point(122, 366);
            this.linkLabelEsqueceu.Name = "linkLabelEsqueceu";
            this.linkLabelEsqueceu.Size = new System.Drawing.Size(108, 13);
            this.linkLabelEsqueceu.TabIndex = 8;
            this.linkLabelEsqueceu.TabStop = true;
            this.linkLabelEsqueceu.Text = "Esqueci minha senha";
            this.linkLabelEsqueceu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEsqueceu_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(355, 694);
            this.Controls.Add(this.linkLabelEsqueceu);
            this.Controls.Add(this.lbSuperFitness);
            this.Controls.Add(this.lblinkCadastro);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Super Fitness - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lbLogin;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.LinkLabel lblinkCadastro;
        private System.Windows.Forms.Label lbSuperFitness;
        private System.Windows.Forms.LinkLabel linkLabelEsqueceu;
    }
}

