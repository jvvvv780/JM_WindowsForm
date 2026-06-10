namespace JumentoCabeamento
{
    partial class Deletar
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
            this.button_DeletarFun = new System.Windows.Forms.Button();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_DeletarFun
            // 
            this.button_DeletarFun.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button_DeletarFun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DeletarFun.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button_DeletarFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeletarFun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_DeletarFun.Location = new System.Drawing.Point(27, 280);
            this.button_DeletarFun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_DeletarFun.Name = "button_DeletarFun";
            this.button_DeletarFun.Size = new System.Drawing.Size(101, 36);
            this.button_DeletarFun.TabIndex = 7;
            this.button_DeletarFun.Text = "Deletar";
            this.button_DeletarFun.UseVisualStyleBackColor = false;
            this.button_DeletarFun.Click += new System.EventHandler(this.button_DeletarFun_Click);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_codigo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_codigo.Location = new System.Drawing.Point(218, 172);
            this.textBox_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(326, 20);
            this.textBox_codigo.TabIndex = 15;
            this.textBox_codigo.TextChanged += new System.EventHandler(this.textBox_codigo_TextChanged);
            // 
            // Deletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JumentoCabeamento.Properties.Resources.layout_deletar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.button_DeletarFun);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Deletar";
            this.Text = "Deletar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DeletarFun;
        private System.Windows.Forms.TextBox textBox_codigo;
    }
}