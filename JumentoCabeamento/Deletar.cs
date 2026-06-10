using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JumentoCabeamento
{
    public partial class Deletar : Form
    {
        DAOFuncionario funcionario;
        public Deletar()
        {
            InitializeComponent();
            this.funcionario = new DAOFuncionario();
        }

        private void textBox_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_DeletarFun_Click(object sender, EventArgs e)
        {
            if (textBox_codigo.Text == "")
            {
                MessageBox.Show("Preencha o código para excluir");
            }
            else
            {
                int codigo = Convert.ToInt32(textBox_codigo.Text);
                string excluir = this.funcionario.Deletar(codigo);
                //Mostrar o resultado na tela
                MessageBox.Show(excluir);
                //Limpar o campo
                textBox_codigo.Text = "";
            }
        }
    }
}
