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
    public partial class cad_usuario : Form
    {
        public SqlConnection Conn = new SqlConnection(Settings.Default.SCGConnectionString);
        public SqlCommand comando = new SqlCommand();
        public SqlDataReader dr;

        public cad_usuario()
        {
            InitializeComponent();
            comando.Connection = Conn;
        }

        private void cad_usuario_Load(object sender, EventArgs e)
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

            senha.Enabled = false;
            senha.Text = String.Empty;

            csenha.Enabled = false;
            csenha.Text = String.Empty;

            tipo.Enabled = false;
            tipo.Text = String.Empty;

        }

        private void button5_Click(object sender, EventArgs e)
        {

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

            senha.Enabled = true;
            senha.Text = string.Empty;

            csenha.Enabled = true;
            csenha.Text = string.Empty;

            tipo.Enabled = true;
            tipo.Text = string.Empty;
            tipo.Text = "VENDEDOR";
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

                senha.Enabled = false;
                senha.Text = String.Empty;

                csenha.Enabled = false;
                csenha.Text = String.Empty;

                tipo.Enabled = false;
                tipo.Text = String.Empty;
            }
        }

        private void gravar_Click(object sender, EventArgs e)
        {
                if (nome.Text == "")
                {
                    MessageBox.Show("Preencha o Campo nome!");
                    nome.Focus();
                }
                else if(senha.Text == "")
                {
                    MessageBox.Show("Preencha o Campo senha!");
                    senha.Focus();

                }
                else if (csenha.Text == "")
                {
                    MessageBox.Show("Preencha o Campo Confirmar senha!");
                    csenha.Focus();

                }
                else if (senha.Text != csenha.Text)
                {
                    MessageBox.Show("Campo confirmar senha divergente do campo senha!");
                    csenha.Text = String.Empty;
                    csenha.Focus();
                }
                else if (nome.Text != "" && senha.Text != "" && csenha.Text != "" && senha.Text == csenha.Text)
                {
                    Conn.Open();
                    comando.CommandText = "INSERT INTO tbusuario (nome,senha,func) values ('" + nome.Text + "','" + senha.Text + "','" + tipo.Text + "')";
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

                    senha.Enabled = false;
                    senha.Text = String.Empty;

                    csenha.Enabled = false;
                    csenha.Text = String.Empty;

                    tipo.Enabled = false;
                    tipo.Text = String.Empty;
                    buscar1();
                }
            

            }
    //CONSULTA SEM INFORMAÇÕES DO CLIENTE
    public void buscar1()

    {
        string _strconn = Settings.Default.SCGConnectionString;
        Conn.Open();
        string strsql = "select id_Login as 'ID',nome as 'Nome Do Usuario', func as 'Tipo de Usuario' from tbusuario";
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
            string strsql = "select id_Login as 'ID',nome as 'Nome Do Usuario', func as 'Tipo de Usuario' from tbusuario where id_login  = '" + id.Text + "'";
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
            comando.CommandText = "select * FROM tbusuario where id_login = '" + id.Text + "'";
            dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    
                    nome.Text = dr[1].ToString();
                    senha.Text = dr[2].ToString();
                    csenha.Text = dr[2].ToString();
                    tipo.Text = dr[3].ToString();
                }
            }
            Conn.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                //CONSULTA SEM INFORMAÇÕES DO CLIENTE
                buscar1();
            }
            if (id.Text != "")
            {
                buscar2();

            }
        }
    }
}
