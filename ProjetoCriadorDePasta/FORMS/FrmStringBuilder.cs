using ProjetoCriadorDePasta.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace ProjetoCriadorDePasta.FORMS
{
    public partial class FrmStringBuilder : Form
    {

        public static string _caminho;
        public static string _nomeArquivo = "configuracao.json";
        public static string _connectionString = "";
        public static Banco _banco = new Banco();

        public FrmStringBuilder()
        {
            _caminho = Path.GetDirectoryName(Application.ExecutablePath);
            InitializeComponent();
        }

        private void btnCriarString_Click(object sender, EventArgs e)
        {
            try
            {
                string server;
                string database;
                string user;
                string password;
                string integrated;

                server = txtServer.Text;
                database = txtDatabase.Text;
                user = txtUser.Text;
                password = txtPassword.Text;
                integrated = txtSecurity.Text;

                _banco = new Banco(server, database, user, password, integrated);
                CreateConnection();
                var json = JsonConvert.SerializeObject(_banco);
                File.WriteAllText(Path.Combine(_caminho, _nomeArquivo), json);
                MessageBox.Show("String criada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateConnection()
        {
            _connectionString = $"Data source = {_banco.Servidor};Integrated Security ={_banco.IngtegratedSecurity} ;Initial Catalog ={_banco.Database};User ID ={_banco.Usuario};Password={_banco.Senha};";

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(_connectionString))
                {
                    cn.Open();
                    MessageBox.Show("Conexão efetuada com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar \n" + ex.Message);
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Tela VoltarTela = new Tela();
            VoltarTela.Show();
            this.Hide();
        }
    }
}
