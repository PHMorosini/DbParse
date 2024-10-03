using Newtonsoft.Json;
using ProjetoCriadorDePasta.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriadorDePasta.FORMS
{
    public partial class FormPath : Form
    {
        public static string _caminho;
        public static string _caminhostring;
        public static string _nomeArquivo = "PathPasta.json";
        public static CaminhoPasta _path;

        public FormPath()
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            _caminho = txtDiretorio.Text;
            _path = new PathDiretory(_caminho);
            CreateConnection();
            var json = JsonConvert.SerializeObject(_path);
            File.WriteAllText(Path.Combine(_caminho, _nomeArquivo), json);
            MessageBox.Show("Caminho configurado com sucesso");
        }
        private void CreateConnection()
        {
            _caminhostring = _path.Caminho;

        }
    }
}