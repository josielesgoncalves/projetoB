namespace ProjetoB.View
{
    partial class AtualizaSenha
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
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbConfirmaSenha = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(90, 35);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 11;
            this.lbCPF.Text = "CPF:";
            // 
            // lbConfirmaSenha
            // 
            this.lbConfirmaSenha.AutoSize = true;
            this.lbConfirmaSenha.Location = new System.Drawing.Point(14, 130);
            this.lbConfirmaSenha.Name = "lbConfirmaSenha";
            this.lbConfirmaSenha.Size = new System.Drawing.Size(106, 13);
            this.lbConfirmaSenha.TabIndex = 13;
            this.lbConfirmaSenha.Text = "CONFIRME SENHA:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(40, 82);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(80, 13);
            this.lbSenha.TabIndex = 12;
            this.lbSenha.Text = "NOVA SENHA:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(153, 32);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(246, 20);
            this.tbCPF.TabIndex = 1;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(153, 75);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(246, 20);
            this.tbSenha.TabIndex = 2;
            // 
            // tbConfirmaSenha
            // 
            this.tbConfirmaSenha.Location = new System.Drawing.Point(153, 123);
            this.tbConfirmaSenha.Name = "tbConfirmaSenha";
            this.tbConfirmaSenha.PasswordChar = '*';
            this.tbConfirmaSenha.Size = new System.Drawing.Size(246, 20);
            this.tbConfirmaSenha.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Location = new System.Drawing.Point(181, 171);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(125, 48);
            this.btnAtualizar.TabIndex = 101;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // AtualizaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(447, 233);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.tbConfirmaSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbConfirmaSenha);
            this.Controls.Add(this.lbCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtualizaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtualizaSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbConfirmaSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbConfirmaSenha;
        private System.Windows.Forms.Button btnAtualizar;
    }
}