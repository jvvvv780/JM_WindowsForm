using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumentoCabeamento
{
    public partial class Consultar : Form
    {
        DAOFuncionario funcionario;
        public Consultar()
        {
            InitializeComponent();
            this.funcionario = new DAOFuncionario();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Clear(); // limpa o grid
            this.funcionario.PreencherVetor();

            for (int i = 0; i < this.funcionario.contar; i++)
            {
                dataGridView1.Rows.Add(
                    this.funcionario.codigo[i],
                    this.funcionario.nome[i],
                    this.funcionario.dataNascimento[i],
                    this.funcionario.estadoCivil[i],
                    this.funcionario.CPF[i],
                    this.funcionario.endereco[i],
                    this.funcionario.telefone[i]
                );
            }
        }//datagrid

        private void Consultar_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Data de Nascimento";
            dataGridView1.Columns[3].Name = "Estado Civil";
            dataGridView1.Columns[4].Name = "CPF";
            dataGridView1.Columns[5].Name = "Endereço";
            dataGridView1.Columns[6].Name = "Teleefone";
        }//fundo

        public void ChamarMetodo(DataGridView datagrid)
        {

            ConfigurarDataGrid(datagrid);//Configuro a estrutura
            NomeColunas(datagrid);//Configuro os nomes
            AdicionarDados(datagrid);//Adiciono os dados
        }//fim do método

        //Nome Colunas
        public void NomeColunas(DataGridView dataGrid)
        {
            dataGrid.Columns[0].Name = "Código";
            dataGrid.Columns[1].Name = "Nome";
            dataGrid.Columns[2].Name = "Data de Nascimento";
            dataGrid.Columns[3].Name = "Estado Civil";
            dataGrid.Columns[4].Name = "CPF";
            dataGrid.Columns[5].Name = "Endereço";
            dataGrid.Columns[6].Name = "Telefone";
        }//fim do método

        //Definir a estrutura da tabela
        public void ConfigurarDataGrid(DataGridView dataGrid)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnCount = 7;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnCount = 7;
        }//fim do configurar

        public void AdicionarDados(DataGridView dataGrid)
        {
            //Primeira coisa será: PREENCHER O VETOR
            this.funcionario.PreencherVetor();
            for (int i = 0; i < this.funcionario.contar; i++)
            {
                dataGrid.Rows.Add(this.funcionario.codigo[i], this.funcionario.nome[i], this.funcionario.dataNascimento[i], this.funcionario.estadoCivil[i], this.funcionario.CPF[i], this.funcionario.endereco[i], this.funcionario.telefone[i]);
            }//fim do for
        }//fim do adicionarDados

        public DataGridView retornarData()
        {
            return dataGridView1;
        }
    }
}