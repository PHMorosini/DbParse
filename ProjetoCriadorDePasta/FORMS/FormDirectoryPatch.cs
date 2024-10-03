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
            if (caminho1 != null && caminho2 != null ) {
                caminho1 = txtDiretorio.Text;
                caminho2 = txtDiretorio2.Text;


                var diretorios = new
                {
                    Diretorio1 = caminho1,
                    Diretorio2 = caminho2
                };

                // Serializa o objeto para uma string JSON
                string JsonString = System.Text.Json.JsonSerializer.Serialize(diretorios, new JsonSerializerOptions { WriteIndented = true });

                // Escreve o JSON em um arquivo

                File.WriteAllText(Path.Combine(_caminho, FileName), JsonString);
            }
            else { MessageBox.Show("Um dos diretorios não foi preenchido corretamente, favor corrigir"); }
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
    }
}
