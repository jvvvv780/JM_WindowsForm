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
    public partial class Atualizar : Form
    {
        DAOFuncionario funcionario;
        public Atualizar()
        {
            InitializeComponent();
            this.funcionario = new DAOFuncionario();
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void textBox_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_dataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_estadoCivil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_AtualizarFun_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox_codigo.Text);

            //Atualizando os dados
            this.funcionario.Atualizar(codigo, "nome", textBox_nome.Text);
            this.funcionario.Atualizar(codigo, "dataNascimento", textBox1_dataNascimento.Text);
            this.funcionario.Atualizar(codigo, "estadoCivil", textBox1_estadoCivil.Text);
            this.funcionario.Atualizar(codigo, "CPF", textBox1_cpf.Text);
            this.funcionario.Atualizar(codigo, "endereco", textBox1_endereco.Text);
            string atualizar = this.funcionario.Atualizar(codigo, "telefone", textBox1_telefone.Text);
            MessageBox.Show(atualizar);

            //Limpar os campos
            textBox_codigo.Text = "";
            textBox_nome.Text = "";
            textBox1_dataNascimento.Text = "";
            textBox1_estadoCivil.Text = "";
            textBox1_cpf.Text = "";
            textBox1_endereco.Text = "";
            textBox1_telefone.Text = "";
        }
    }
}
