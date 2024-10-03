using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriadorDePasta.Classes
{
    public class CaminhoPasta
    {
        public string Caminho { get; set; }
        public CaminhoPasta(string caminho)
        {
            Caminho = caminho;
        }
    }
}
