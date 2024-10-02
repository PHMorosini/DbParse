using CriarPastaBancoNovo;
using ProjetoCriadorDePasta.FORMS;
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

namespace ProjetoCriadorDePasta
{
    public partial class Tela : Form
    {
        string nomePastaPrincipal;
        public Tela()
        {
            InitializeComponent();
        }

        private void Tela_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btCriarPasta_Click(object sender, EventArgs e)
        {

            nomePastaPrincipal = Utilitys.LimparNomeDaPasta(nomePastaPrincipal);
            string caminhoPastaPrincipal = Path.Combine(@"D:\Migração\Bancos", nomePastaPrincipal);

            if (rbWEB.Checked)
            {
                    // Cria a pasta principal
                    Directory.CreateDirectory(caminhoPastaPrincipal);
                    Console.WriteLine($"Pasta principal '{nomePastaPrincipal}' criada com sucesso em {caminhoPastaPrincipal}");

                    // Caminho das pastas existentes
                    string caminhoPastaExistente1 = @"D:\Migração\Arquivos uteis\Banco";
                    string caminhoPastaExistente2 = @"D:\Migração\Arquivos uteis\ARQUIVOS_WEB_ZERADO";
                    string caminhoPastaExistente3 = @"D:\Migração\Arquivos uteis\Script_web_com_replace";


                    // Cria cópias das pastas existentes na pasta principal
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente1, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente2, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente3, caminhoPastaPrincipal);
            }
            else
            {
                if (rbAtual.Checked)
                {
                    // Cria a pasta principal
                    Directory.CreateDirectory(caminhoPastaPrincipal);

                    // Caminho das pastas existentes
                    string caminhoPastaExistente1 = @"D:\Migração\04A - Projetos\04A - Projetos\Atual Sistemas - PostgreSQL";
                    string caminhoPastaExistente2 = @"D:\Migração\Arquivos uteis\BancoVarejo";
                    string caminhoPastaExistente3 = @"D:\Migração\Arquivos uteis\ARQUIVOS";
                    string caminhoPastaExistente4 = @"D:\Migração\Arquivos uteis\Banco";


                    // Cria cópias das pastas existentes na pasta principal
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente1, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente2, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente3, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente4, caminhoPastaPrincipal);

                }
                else if (rbUniplus.Checked)
                {

                    // Cria a pasta principal
                    Directory.CreateDirectory(caminhoPastaPrincipal);
                    Console.WriteLine($"Pasta principal '{nomePastaPrincipal}' criada com sucesso em {caminhoPastaPrincipal}");

                    // Caminho das pastas existentes
                    string caminhoPastaExistente1 = @"D:\Migração\04A - Projetos\04A - Projetos\Uniplus";
                    string caminhoPastaExistente2 = @"D:\Migração\Arquivos uteis\BancoVarejo";
                    string caminhoPastaExistente3 = @"D:\Migração\Arquivos uteis\ARQUIVOS";
                    string caminhoPastaExistente4 = @"D:\Migração\Arquivos uteis\Banco";


                    // Cria cópias das pastas existentes na pasta principal
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente1, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente2, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente3, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente4, caminhoPastaPrincipal);

                }
                else if (rbAlterData.Checked)
                {

                    // Cria a pasta principal
                    Directory.CreateDirectory(caminhoPastaPrincipal);
                    Console.WriteLine($"Pasta principal '{nomePastaPrincipal}' criada com sucesso em {caminhoPastaPrincipal}");

                    // Caminho das pastas existentes
                    string caminhoPastaExistente1 = @"D:\Migração\04A - Projetos\04A - Projetos\AlterData";
                    string caminhoPastaExistente2 = @"D:\Migração\Arquivos uteis\BancoVarejo";
                    string caminhoPastaExistente3 = @"D:\Migração\Arquivos uteis\ARQUIVOS";
                    string caminhoPastaExistente4 = @"D:\Migração\Arquivos uteis\Banco";


                    // Cria cópias das pastas existentes na pasta principal
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente1, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente2, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente3, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente4, caminhoPastaPrincipal);

                }
                else if (rbNewProject.Checked)
                {
                    // Cria a pasta principal
                    Directory.CreateDirectory(caminhoPastaPrincipal);
                    Console.WriteLine($"Pasta principal '{nomePastaPrincipal}' criada com sucesso em {caminhoPastaPrincipal}");

                    // Caminho das pastas existentes
                    string caminhoPastaExistente2 = @"D:\Migração\Arquivos uteis\BancoVarejo";
                    string caminhoPastaExistente3 = @"D:\Migração\Arquivos uteis\ARQUIVOS";
                    string caminhoPastaExistente1 = @"D:\Migração\Arquivos uteis\Banco";


                    // Cria cópias das pastas existentes na pasta principal
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente1, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente2, caminhoPastaPrincipal);
                    Utilitys.CriarCopiaPasta(caminhoPastaExistente3, caminhoPastaPrincipal);

                }
                
            }
            MessageBox.Show("Pasta criada com sucesso");
        }

        private void rbVarejo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVarejo.Checked)
            {
                label4.Visible = true;
                rbUniplus.Visible = true;
                rbAtual.Visible = true;
                rbAlterData.Visible = true;
                rbNewProject.Visible = true;
            }
        }

        private void rbUniplus_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rbAtual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNewProject_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nomePastaPrincipal_TextChanged(object sender, EventArgs e)
        {

            //castando o treco pra textbox pra poder usar o parametro textbox e pegar o text do textbox aaaaaaaaaaa que bagui chato de explica
            if (sender is TextBox textBox)
            {
                // Obtém o texto do TextBox
                nomePastaPrincipal = textBox.Text;
            }
        }

        private void rbWEB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWEB.Checked)
            {
                label4.Visible = false;
                rbUniplus.Visible = false;
                rbAtual.Visible = false;
                rbAlterData.Visible = false;
                rbNewProject.Visible = false;
            }
        }

        private void btChecarProjetos_Click(object sender, EventArgs e)
        {
            Form2 Abrirtela2 = new Form2();
            Abrirtela2.Show();
            this.Hide();
        }

        private void btAbrirQuerry_Click(object sender, EventArgs e)
        {
            Form3 AbriTela = new Form3();
            AbriTela.Show();
            this.Hide();

        }

        private void btnStringConexão_Click(object sender, EventArgs e)
        {
            FrmStringBuilder AbrirTela = new FrmStringBuilder();
            AbrirTela.Show();
            this.Hide();
        }
    }
}
