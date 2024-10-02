using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriadorDePasta.Classes
{
    public class Banco
    {
        public string Servidor { get; set; }
        public string Database { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string IngtegratedSecurity { get; set; }

        public Banco(string server, string database, string usuario, string senha, string integrated)
        {
            Servidor = server;
            Database = database;
            Usuario = usuario;
            Senha = senha;
            IngtegratedSecurity = integrated;
        }

        public Banco()
        {

        }
    }
}
