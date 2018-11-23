namespace ProjetoB
{
    partial class CalorieControl
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
            this.label = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCalorias = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listViewAlimentos = new System.Windows.Forms.ListView();
            this.lvIngeridos = new System.Windows.Forms.ListView();
            this.lbDica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(239, 348);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 35);
            this.label.TabIndex = 3;
            this.label.Text = "Calorias:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Cafés, chás e sucos",
            "Bebidas alcoólicas",
            "Refrigerantes e energéticos",
            "Carnes",
            "Embutidos",
            "Peixes e frutos do mar",
            "Biscoitos e bolachas",
            "Balas",
            "Bolos",
            "Chocolates",
            "Doces",
            "Gelatinas",
            "Sorvetes",
            "Adoçantes e condimentos",
            "Cremes e molhos",
            "Gorduras e óleos",
            "Frutas secas e frescas",
            "Iorgutes ",
            "Leites",
            "Queijos",
            "Ovos",
            "Legumes, verduras e grãos ",
            "Pães",
            "Massas e pizzas",
            "Cereais, farinhas e complementos",
            "Pratos caseiros e industrializados",
            "Sanduíches"});
            this.comboCategoria.Location = new System.Drawing.Point(243, 72);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(267, 21);
            this.comboCategoria.TabIndex = 16;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Categoria do alimento";
            // 
            // lbCalorias
            // 
            this.lbCalorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCalorias.Location = new System.Drawing.Point(320, 348);
            this.lbCalorias.Name = "lbCalorias";
            this.lbCalorias.Size = new System.Drawing.Size(75, 35);
            this.lbCalorias.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(435, 348);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 35);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listViewAlimentos
            // 
            this.listViewAlimentos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAlimentos.Location = new System.Drawing.Point(12, 131);
            this.listViewAlimentos.Name = "listViewAlimentos";
            this.listViewAlimentos.Size = new System.Drawing.Size(550, 199);
            this.listViewAlimentos.TabIndex = 20;
            this.listViewAlimentos.UseCompatibleStateImageBehavior = false;
            this.listViewAlimentos.SelectedIndexChanged += new System.EventHandler(this.listViewAlimentos_SelectedIndexChanged);
            // 
            // lvIngeridos
            // 
            this.lvIngeridos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvIngeridos.Location = new System.Drawing.Point(588, 131);
            this.lvIngeridos.Name = "lvIngeridos";
            this.lvIngeridos.Size = new System.Drawing.Size(200, 199);
            this.lvIngeridos.TabIndex = 22;
            this.lvIngeridos.UseCompatibleStateImageBehavior = false;
            // 
            // lbDica
            // 
            this.lbDica.AutoSize = true;
            this.lbDica.Location = new System.Drawing.Point(12, 115);
            this.lbDica.Name = "lbDica";
            this.lbDica.Size = new System.Drawing.Size(148, 13);
            this.lbDica.TabIndex = 23;
            this.lbDica.Text = "Selecione os itens que ingeriu";
            // 
            // CalorieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDica);
            this.Controls.Add(this.lvIngeridos);
            this.Controls.Add(this.listViewAlimentos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.lbCalorias);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalorieControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalorieControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCalorias;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListView listViewAlimentos;
        private System.Windows.Forms.ListView lvIngeridos;
        private System.Windows.Forms.Label lbDica;
    }
}