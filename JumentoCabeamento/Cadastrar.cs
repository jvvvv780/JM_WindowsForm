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
    public partial class Cadastrar : Form
    {
        DAOFuncionario funcionario;
        public Cadastrar()
        {
            InitializeComponent();
            this.funcionario = new DAOFuncionario();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
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

        private void button_CadastrarFun_Click(object sender, EventArgs e)
        {
            if ((textBox_nome.Text == "") || (textBox1_dataNascimento.Text == "") || (textBox1_estadoCivil.Text == "") || (textBox1_cpf.Text == "") || (textBox1_endereco.Text == "") || (textBox1_telefone.Text == ""))
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {
                string nome = textBox_nome.Text;
                DateTime dataNascimento = DateTime.Parse(textBox1_dataNascimento.Text);
                string estadoCivil = textBox1_estadoCivil.Text;
                long CPF = long.Parse (textBox1_cpf.Text);
                string endereco = textBox1_endereco.Text;
                string telefone = textBox1_telefone.Text;
                //Inserir dentro do banco
                this.funcionario.Inserir(nome, dataNascimento, estadoCivil, CPF, endereco, telefone);
                //Limpar os campos
                LimparCampos();
            }
        }

        public void LimparCampos()
        {
            textBox_nome.Text = "";
            textBox1_dataNascimento.Text = "";
            textBox1_estadoCivil.Text = "";
            textBox1_cpf.Text = "";
            textBox1_endereco.Text = "";
            textBox1_telefone.Text = "";
        }//fim do método
    }
}
