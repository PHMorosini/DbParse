using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriadorDePasta.Classes
{
    public class Conn2
    {
        public static string _caminho;
        public static string _nomeArquivo = "configuracao.json";
        public static string _connectionString = "";

        Banco banco = new Banco();

        public static string StrCon
        {

            get
            {
                _caminho = Path.GetDirectoryName(Application.ExecutablePath);
                var dados = File.ReadAllText(Path.Combine(_caminho, _nomeArquivo));
                var configuracao = JsonConvert.DeserializeObject<Banco>(dados);
                return _connectionString = $"Data Source={configuracao.Servidor};Integrated Security ={configuracao.IngtegratedSecurity} ;Initial Catalog={configuracao.Database};User ID={configuracao.Usuario};Password={configuracao.Senha};";
            }
        }

    }
}
