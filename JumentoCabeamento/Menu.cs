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
    public partial class Menu : Form
    {
        Cadastrar cad;
        Atualizar atu;
        Deletar del;
        Consultar con;

        public Menu()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            cad = new Cadastrar();
            cad.ShowDialog();
        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            atu = new Atualizar();
            atu.ShowDialog();

        }

        private void button_Deletar_Click(object sender, EventArgs e)
        {
            del = new Deletar();
            del.ShowDialog();
        }

        private void button_Consultar_Click(object sender, EventArgs e)
        {
            con = new Consultar();
            con.ShowDialog();
        }
    }
}
