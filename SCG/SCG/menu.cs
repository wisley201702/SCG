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

        }

        private void oRÇAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_usuario frm = new cad_usuario();
            frm.Show();
            Visible = true;
        }
    }
}
