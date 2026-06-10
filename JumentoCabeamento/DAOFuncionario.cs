using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumentoCabeamento
{
    class DAOFuncionario
    {
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public int i;
        public int contar;
        public int[] codigo;
        public string[] nome;
        public DateTime[] dataNascimento;
        public string[] estadoCivil;
        public long[] CPF;
        public string[] endereco;
        public string[] telefone;

        public DAOFuncionario()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=jumentocabeamento;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//Abrindo a conexão
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado!\n\n {erro}");
                conexao.Close();//Fecha conexão com o banco de dados
            }//Fim do método try_catch
        }

        public void Inserir(string nome, DateTime dataNascimento, string estadoCivil, long CPF, string endereco, string telefone)
        {
            try
            {
                string dataString = dataNascimento.ToString("yyyy-MM-dd");
                this.dados = $"('', '{nome}', '{dataString}', '{estadoCivil}', '{CPF}', '{endereco}', '{telefone}')";
                this.comando = $"Insert into funcionario(codigo, nome, dataNascimento, estadoCivil, CPF, endereco, telefone) values{this.dados}";
                //Inserir comando
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show($"Inserido com Sucesso! \n\n{resultado}");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado\n\n {erro}");
            }//Fim do método try_catch
        }//Fim do Inserir

        public void PreencherVetor()
        {
            string query = "select * from funcionario";//Buscando todos os dados da tabela autor
            //Instanciar os vetores
            this.codigo = new int[100];
            this.nome = new string[100];
            this.dataNascimento = new DateTime[100];
            this.estadoCivil = new string[100];
            this.CPF = new long[100];
            this.endereco = new string[100];
            this.telefone = new string[100];

            //Preencher os vetores com valores padrões
            for (i = 0; i < 100; i++)
            {
                this.codigo[i] = 0;
                this.nome[i] = "";
                this.dataNascimento[i] = DateTime.Now;
                this.estadoCivil[i] = "";
                this.CPF[i] = 0; 
                this.endereco[i] = "";
                this.telefone[i] = "";
            }//Fim do for

            //Executar o comando do SQL
            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            //Leitura do dado no banco
            MySqlDataReader leitura = coletar.ExecuteReader();//Percorre o banco e traz os dados

            //Zerar o contador
            i = 0;
            this.contar = 0;
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.nome[i] = leitura["nome"] + "";
                this.dataNascimento[i] = Convert.ToDateTime(leitura["dataNascimento"]);
                this.estadoCivil[i] = leitura["estadoCivil"] + "";
                this.CPF[i] = Convert.ToInt64(leitura["CPF"]);
                this.endereco[i] = leitura["endereco"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                i++;
                this.contar++;
            }//fim do while
            leitura.Close();//Encerrando o processo de busca
        }//Fim do PreencherVetor

        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update funcionario set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //executar o comando

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
                return $"Atualizado com sucesso!\n\n{resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro}";
            }//Fim do método try_catch
        }//Fim do Atualizar

        public string Deletar(int codigo)
        {
            try
            {
                string query = $"delete from funcionario where codigo = '{codigo}'";
                //executar o comando

                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//comando da inserção no banco
                return $"Deletado com sucesso!\n\n{resultado}";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n{erro}";
            }//Fim do método try_catch
        }//Fim do Deletar


    }//Fim da classe
}//Fim do Projeto