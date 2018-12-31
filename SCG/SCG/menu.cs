using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCG
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void entradaNoEstoqueSNFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 15;
        }

        private void oRÇAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 17;
        }

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 25;
            cad_usuario frm = new cad_usuario();
            frm.Show();
            Visible = true;
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 26;
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // id_modulo = 1;
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 2;
            grupo frm = new grupo();
            frm.Show();
            Visible = true;
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 3;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 4;
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 5;
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 6;
        }

        private void cadastroConfiguradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 7;
        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 8;
        }

        private void locaisDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 9;
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 10;
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 11;
        }

        private void movimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 12;
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 13;
        }

        private void ajusteNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 14;
        }

        private void entradaNoEstoqueCNFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 16;
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 18;
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //int id_modulo = 19;
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 20;
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 21;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 22;
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 23;
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int id_modulo = 24;
        }
    }
}
