using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriadorDePasta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetosCriadosVarejoDataSet1.NomeProjeto'. Você pode movê-la ou removê-la conforme necessário.
            this.nomeProjetoTableAdapter.Fill(this.projetosCriadosVarejoDataSet1.NomeProjeto);
            dgTabela.AutoGenerateColumns = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btConectarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    MessageBox.Show("Conectado ao banco de dados");
                    label1.Visible = true;
                    dgTabela.Visible = true;
                    btConectarBanco.Visible = false;
                    btVoltar.Visible = true;
                    btCadastrarProjeto.Visible = true;
                    label2.Visible = true;
                    btBuscar.Visible = true;
                    txtNomeBusca.Visible = true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar \n" + ex.Message);
            }


        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Tela VoltarTela = new Tela();
            VoltarTela.Show();
            this.Hide();
        }

        private void btCadastrarProjeto_Click(object sender, EventArgs e)
        {
            TelaCadastro TelaCadastro = new TelaCadastro();
            TelaCadastro.Show();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Querry();
        }

        private void Querry()
        {
            string TextoPesquisa = txtNomeBusca.Text;
            if (TextoPesquisa == "%") {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string Querry = "SELECT * FROM NomeProjeto";
                        SqlDataAdapter da = new SqlDataAdapter(Querry, cn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgTabela.DataSource = dt;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao fazer a busca \n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        string Querry = "SELECT * FROM NomeProjeto where Nome like @TextoPesquisa";

                        using (SqlCommand cmd = new SqlCommand(Querry, cn))
                        {
                            cmd.Parameters.AddWithValue("@TextoPesquisa",  TextoPesquisa + "%");

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgTabela.DataSource = dt;
                        }
                        cn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao fazer a busca \n" + ex.Message);
                }
            }
        }

        private void txtNomeBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
