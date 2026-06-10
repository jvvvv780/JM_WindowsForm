namespace JumentoCabeamento
{
    partial class Menu
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
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Atualizar = new System.Windows.Forms.Button();
            this.button_Deletar = new System.Windows.Forms.Button();
            this.button_Consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.button_Cadastrar.Location = new System.Drawing.Point(158, 114);
            this.button_Cadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(284, 47);
            this.button_Cadastrar.TabIndex = 0;
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Atualizar
            // 
            this.button_Atualizar.BackColor = System.Drawing.Color.Transparent;
            this.button_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Atualizar.ForeColor = System.Drawing.Color.Transparent;
            this.button_Atualizar.Location = new System.Drawing.Point(158, 167);
            this.button_Atualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Atualizar.Name = "button_Atualizar";
            this.button_Atualizar.Size = new System.Drawing.Size(284, 47);
            this.button_Atualizar.TabIndex = 1;
            this.button_Atualizar.UseVisualStyleBackColor = false;
            this.button_Atualizar.Click += new System.EventHandler(this.button_Atualizar_Click);
            // 
            // button_Deletar
            // 
            this.button_Deletar.BackColor = System.Drawing.Color.Transparent;
            this.button_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Deletar.ForeColor = System.Drawing.Color.Transparent;
            this.button_Deletar.Location = new System.Drawing.Point(158, 219);
            this.button_Deletar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Deletar.Name = "button_Deletar";
            this.button_Deletar.Size = new System.Drawing.Size(284, 47);
            this.button_Deletar.TabIndex = 2;
            this.button_Deletar.UseVisualStyleBackColor = false;
            this.button_Deletar.Click += new System.EventHandler(this.button_Deletar_Click);
            // 
            // button_Consultar
            // 
            this.button_Consultar.BackColor = System.Drawing.Color.Transparent;
            this.button_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consultar.ForeColor = System.Drawing.Color.Transparent;
            this.button_Consultar.Location = new System.Drawing.Point(158, 273);
            this.button_Consultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Consultar.Name = "button_Consultar";
            this.button_Consultar.Size = new System.Drawing.Size(284, 47);
            this.button_Consultar.TabIndex = 3;
            this.button_Consultar.UseVisualStyleBackColor = false;
            this.button_Consultar.Click += new System.EventHandler(this.button_Consultar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JumentoCabeamento.Properties.Resources.layout_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_Consultar);
            this.Controls.Add(this.button_Deletar);
            this.Controls.Add(this.button_Atualizar);
            this.Controls.Add(this.button_Cadastrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Atualizar;
        private System.Windows.Forms.Button button_Deletar;
        private System.Windows.Forms.Button button_Consultar;
    }
}

