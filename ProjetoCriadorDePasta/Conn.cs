using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriadorDePasta
{
    internal class Conn
    {
        private static string server = @"MIGRACAO\OBJETIVA";
        private static string dataBase = "ProjetosCriadosVarejo";
        private static string user = @"OBJETIVA\migracao";
        private static string password = "";
        public static string StrCon
        {
            get { return "Data Source=" + server + "; Integrated Security = true;Initial Catalog =" + dataBase + "; User Id =" + user + "; Password=" + password; }
        }


    }

}
