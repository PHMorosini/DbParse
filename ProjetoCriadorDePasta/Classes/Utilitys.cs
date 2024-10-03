using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriarPastaBancoNovo
{
    internal class Utilitys
    {

        public static void CriarCopiaPasta(string caminhoPastaExistente, string caminhoPastaDestino)
        {
            try
            {
                string nomePastaExistente = new DirectoryInfo(caminhoPastaExistente).Name;
                string caminhoDestino = Path.Combine(caminhoPastaDestino, nomePastaExistente);

                // copia a pasta existente pra pasta nova
                CopiarDiretorio(caminhoPastaExistente, caminhoDestino);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar a cópia da pasta: {ex.Message}");
            }
        }
        //é oque vai fazer a copia dos arquivos do diretorio(pasta)
        public static void CopiarDiretorio(string origem, string destino)
        {
            if (!Directory.Exists(destino))
            {
                Directory.CreateDirectory(destino);
            }

            foreach (string arquivo in Directory.GetFiles(origem, "*.*"))
            {
                string nomeArquivo = Path.GetFileName(arquivo);
                string destinoArquivo = Path.Combine(destino, nomeArquivo);
                File.Copy(arquivo, destinoArquivo, true);
            }

            foreach (string subdiretorio in Directory.GetDirectories(origem))
            {
                string nomeSubdiretorio = new DirectoryInfo(subdiretorio).Name;
                string destinoSubdiretorio = Path.Combine(destino, nomeSubdiretorio);
                CopiarDiretorio(subdiretorio, destinoSubdiretorio);
            }
        }
        //Limpa o nome da pasta pra garantir q nn tem coisa errada
        public static string LimparNomeDaPasta(string nomeDaPasta)
        {
            try
            { 
                foreach (char c in Path.GetInvalidFileNameChars())
                {
                    nomeDaPasta = nomeDaPasta.Replace(c.ToString(), "");
                }

                return nomeDaPasta;
            }
            catch(Exception e) { 
            
              MessageBox.Show("É necessario ter um nome para a pasta antes de criar-la.");
                return null;
            }
            
           
        }

        public static void CriarCaminhoPasta() 
        {
        
        }

    }
}
