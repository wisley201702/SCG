using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SCG.Properties;

namespace SCG
{
    public partial class grupo : Form
    {
        public SqlConnection Conn = new SqlConnection(Settings.Default.SCGConnectionString);
        public SqlCommand comando = new SqlCommand();
        public SqlDataReader dr;

        public grupo()
        {
            InitializeComponent();
            comando.Connection = Conn;
        }

        private void grupo_Load(object sender, EventArgs e)
        {
            //Função da Tela Iniciar
            buscar1();
            novo.Enabled = true;
            alterar.Enabled = false;
            cancelar.Enabled = false;
            gravar.Enabled = false;
            cancelar.Enabled = true;
            excluir.Enabled = false;
            buscar.Enabled = true;
            id.Enabled = true;
            id.Text = String.Empty;
            id.Focus();

            nome.Enabled = false;
            nome.Text = String.Empty;

        }

        private void novo_Click(object sender, EventArgs e)
        {
            novo.Enabled = false;
            alterar.Enabled = false;
            gravar.Enabled = true;
            excluir.Enabled = false;
            cancelar.Enabled = true;
            buscar.Enabled = false;
            id.Enabled = false;
            id.Text = string.Empty;


            nome.Focus();
            nome.Enabled = true;
            nome.Text = string.Empty;

        }

        private void alterar_Click(object sender, EventArgs e)
        {
            novo.Enabled = false;
            alterar.Enabled = false;
            gravar.Enabled = true;
            excluir.Enabled = false;
            cancelar.Enabled = true;

            Conn.Open();
            comando.CommandText = "select * FROM tbgrupo where nome='" + nome.Text + "'";
            dr = comando.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    id.Enabled = false;
                    nome.Enabled = true;
                }
            }
            Conn.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Cancelar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                novo.Enabled = true;
                alterar.Enabled = false;
                cancelar.Enabled = false;
                gravar.Enabled = false;
                cancelar.Enabled = true;
                excluir.Enabled = false;
                buscar.Enabled = true;
                id.Enabled = true;
                id.Text = String.Empty;
                id.Focus();

                nome.Enabled = false;
                nome.Text = String.Empty;
            }
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                if (nome.Text == "")
                {
                    MessageBox.Show("Preencha o Campo nome!");
                    nome.Focus();
                }
                else if (nome.Text != "")
                {
                    Conn.Open();
                    comando.CommandText = "INSERT INTO tbgrupo (nome) values ('" + nome.Text + "')";
                    comando.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Salvo Com Sucesso!");
                    novo.Enabled = true;
                    alterar.Enabled = false;
                    cancelar.Enabled = false;
                    gravar.Enabled = false;
                    cancelar.Enabled = true;
                    excluir.Enabled = false;
                    buscar.Enabled = true;
                    id.Enabled = true;
                    id.Text = String.Empty;
                    id.Focus();

                    nome.Enabled = false;
                    nome.Text = String.Empty;

                    buscar1();
                }
            }
            else if (id.Text != "" && id.Enabled == false)
            {
                if (nome.Text == "")
                {
                    MessageBox.Show("Preencha o Campo nome!");
                    nome.Focus();
                }
                else if (id.Text != "" && nome.Text != "")
                {
                    Conn.Open();
                    comando.CommandText = "UPDATE tbgrupo SET nome = '" + nome.Text +"'";
                    comando.ExecuteNonQuery();
                    Conn.Close();
                    MessageBox.Show("Atualizado com sucesso!");
                    novo.Enabled = true;
                    alterar.Enabled = false;
                    cancelar.Enabled = false;
                    gravar.Enabled = false;
                    cancelar.Enabled = true;
                    excluir.Enabled = false;
                    buscar.Enabled = true;
                    id.Enabled = true;
                    id.Text = String.Empty;
                    id.Focus();

                    nome.Enabled = false;
                    nome.Text = String.Empty;

                    buscar1();
                }

            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            String CodExclusao = "";
            String Validador = "";
            CodExclusao = id.Text;
            Conn.Open();

            comando.CommandText = "select * FROM tbusuario where id_login='" + CodExclusao + "'";

            dr = comando.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Validador = dr[0].ToString();

                }
            }
            Conn.Close();

            if (CodExclusao == "")
            {
                MessageBox.Show("informar codigo de Exclusão!");
            }
            else if (Validador == CodExclusao)
            {
                if (MessageBox.Show("Tem certeza que deseja Excluir o Usuario?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conn.Open();
                    comando.CommandText = "delete from tbgrupo where id_login='" + id.Text + "'";
                    dr = comando.ExecuteReader();
                    MessageBox.Show("Grupo Excluido Com Sucesso!");
                    Conn.Close();
                    buscar1();

                }
                else
                {
                    MessageBox.Show("Cancelameto de OPERAÇÃO pelo usuario!");
                    buscar1();
                }

            }
            else
            {
                MessageBox.Show("Codigo incorreto ou Cancelameto de OPERAÇÃO pelo usuario!");
                buscar1();
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                //CONSULTA SEM INFORMAÇÕES DO CLIENTE
                buscar1();
                excluir.Enabled = true;

            }
            if (id.Text != "")
            {
                buscar2();
                string _strconn = Settings.Default.SCGConnectionString;
                excluir.Enabled = true;

            }
        }
        //CONSULTA SEM INFORMAÇÕES DO CLIENTE
        public void buscar1()

        {
            string _strconn = Settings.Default.SCGConnectionString;
            Conn.Open();
            string strsql = "select id_grupo as 'ID',nome as 'Nome Do Grupo' from tbusuario";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);
            Conn.Close();

            try
            {
                Conn.Open();
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgusuario.DataSource = drlista;
                Conn.Close();

            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }

        }
        //buscar por codigo
        public void buscar2()

        {
            string _strconn = Settings.Default.SCGConnectionString;
            Conn.Open();
            string strsql = "select id_grupo as 'ID',nome as 'Nome Do Grupo' from tbgrupo where id_login  = '" + id.Text + "'";
            SqlConnection objconnect = null;
            SqlCommand objcomando = null;
            objconnect = new SqlConnection(_strconn);
            objcomando = new SqlCommand(strsql, objconnect);
            try
            {
                SqlDataAdapter objAdp = new SqlDataAdapter(objcomando);
                DataTable drlista = new DataTable();
                objAdp.Fill(drlista);
                dgusuario.DataSource = drlista;

            }
            catch
            {
                MessageBox.Show("Deu erro!");
            }

            Conn.Close();
        }

        private void dgusuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega a linha onde foi originado o evento
            var row = dgusuario.Rows[e.RowIndex];


            //passa para um método responsável por preencher todos os textboxes  
            SeuMetodo(row);
        }
        public void SeuMetodo(DataGridViewRow row)
        {
            id.Text = row.Cells["ID"].Value.ToString();
            nome.Text = row.Cells["Nome Do Usuario"].Value.ToString();
            tipo.Text = row.Cells["Tipo de Usuario"].Value.ToString();
            novo.Enabled = true;
            alterar.Enabled = true;
            cancelar.Enabled = true;
            gravar.Enabled = false;
            excluir.Enabled = true;
            buscar.Enabled = true;


        }
    }
}
