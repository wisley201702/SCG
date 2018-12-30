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
    public partial class Login : Form
    {
        public SqlConnection Conn = new SqlConnection(Settings.Default.SCGConnectionString);
        public SqlCommand comando = new SqlCommand();
        public SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
            comando.Connection = Conn;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usuario.Focus();
            usuario.Text = String.Empty;
            senha.Text = String.Empty;
            //Propriedade Style = csDropDownList;
            try
            {
                Conn.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select nome from tbusuario";
            SqlDataAdapter da = new SqlDataAdapter(scom, Conn);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            usuario.DataSource = null;
            da.Fill(dtResultado);
            usuario.DataSource = dtResultado;
            usuario.ValueMember = "nome";
            usuario.DisplayMember = "descricao";
            usuario.SelectedItem = "";
            usuario.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void ok_Click(object sender, EventArgs e)
        {
            //validação de login
            String x = "";
            String y = "";
            if (usuario.Text == "" && senha.Text == "suportewisley")
            {
                MessageBox.Show("Dados Informado Corretamente!");
                menu frm = new menu();
                frm.Show();
                Visible = false;
            }
            else
            {
                Conn.Open();
                comando.CommandText = "select * FROM tbusuario where nome='" + usuario.Text + "'and senha='" + senha.Text + "'";
                dr = comando.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        x = dr[1].ToString();
                        y = dr[2].ToString();
                    }

                }
                Conn.Close();
                if (usuario.Text != x && senha.Text != y)
                {
                    MessageBox.Show("Dados Informado Invalidos!");
                    usuario.Text = String.Empty;
                    senha.Text = String.Empty;
                    usuario.Focus();

                }
                else if (x == "" && y == "")
                {
                    MessageBox.Show("Dados Informado Invalidos!");
                    usuario.Text = String.Empty;
                    senha.Text = String.Empty;
                    usuario.Focus();
                }
                else if (usuario.Text == "" && usuario.Text == "")
                {
                    MessageBox.Show("Informe Usuario e Senha!");
                    usuario.Text = String.Empty;
                    senha.Text = String.Empty;
                    usuario.Focus();

                }
                else
                {
                    MessageBox.Show("Dados Informados Corretamente!");
                    menu frm = new menu();
                    frm.Show();
                    Visible = false;
                }

            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            //botão cancelar limpa campos e volta o foco para nome 
            usuario.Focus();
            usuario.Text = String.Empty;
            senha.Text = String.Empty;
        }

        private void usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
