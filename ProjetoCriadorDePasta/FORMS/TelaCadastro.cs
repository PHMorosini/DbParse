using System;
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
    
    public partial class TelaCadastro : Form
    {
       
        
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void Cadastrar()
        {
            string nomeAutor = txtNomeAutor.Text;
            string nomeBanco= txtNomeBanco.Text;
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    var sql = "INSERT INTO NomeProjeto(Nome,Criador) VALUES (@Nome,@Criador)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nomeBanco);
                        cmd.Parameters.AddWithValue("@Criador", nomeAutor);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Projeto cadastrado com sucesso");
                    }
                    cn.Close();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o banco { ex.Message}");
            }
        }

        private void CadastrarProjeto_Click(object sender, EventArgs e)
        {
            Cadastrar();
            this.Close();
        }
    }
}
