using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriadorDePasta.FORMS
{
    public partial class FormDirectoryPatch : Form
    {
        string caminho1;
        string caminho2; 
        string _caminho;
        string FileName = "ConfiguracaoDiretorio.Json";

        public FormDirectoryPatch()
        {
            _caminho = Path.GetDirectoryName(Application.ExecutablePath);
            InitializeComponent();
        }

        private void btPesquisaDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDiretorio.Text = dlg.SelectedPath;
            
        }

        private void btPesquisaDiretorio2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDiretorio2.Text = dlg.SelectedPath;
        }

        public void CriarJsonCaminho()
        {
            try
            {
                caminho1 = txtDiretorio.Text;
                caminho2 = txtDiretorio2.Text;

                if (!string.IsNullOrWhiteSpace(caminho1) && !string.IsNullOrWhiteSpace(caminho2))
                {
                    var diretorios = new
                    {
                        Diretorio1 = caminho1,
                        Diretorio2 = caminho2
                    };

                    string jsonString = System.Text.Json.JsonSerializer.Serialize(diretorios, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(Path.Combine(_caminho, FileName), jsonString);
                    MessageBox.Show("Arquivo de configuração salvo com sucesso");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Um dos diretórios não foi preenchido corretamente, favor corrigir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                CriarJsonCaminho();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel criar o arquivo de configuração, Erro:" + ex);
            }
        }

        private void FormDirectoryPatch_Load(object sender, EventArgs e)
        {

        }
    }
}
