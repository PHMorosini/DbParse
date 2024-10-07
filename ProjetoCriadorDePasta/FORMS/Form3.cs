using ProjetoCriadorDePasta.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriadorDePasta.FORMS
{
    public partial class Form3 : Form
    {

        List<SqlConnection> conexoesAbertas = new List<SqlConnection>();
        public Form3()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form3_FormClosed);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn2.StrCon))
                {
                    cn.Open();
                    MessageBox.Show("Conectado ao banco de dados");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar \n" + ex.Message);
            }


        }
        private void btVoltar_Click_1(object sender, EventArgs e)
        {
            Tela VoltarTela = new Tela();
            VoltarTela.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPesquisaDiretorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowDialog();
            txtDiretorio.Text = dlg.SelectedPath;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btGerarArquivos_Click(object sender, EventArgs e)
        {

            Querry minhaQuerry = new Querry();
            string folderPath = txtDiretorio.Text;
            string filialescolhida = txtFilial.Text;
            
            minhaQuerry.CorrecoesBanco();

            try
            {
                if (folderPath.Length > 0)
                {
                    //cliente
                    string client = Path.Combine(folderPath, "01 - CLIENTES.txt");
                    string clientendereco = Path.Combine(folderPath, "01.1 - ENDERECOCLIENTE.txt");
                    string clientetelefone = Path.Combine(folderPath, "01.2 - TELEFONECLIENTE.txt");
                    string clienteemail = Path.Combine(folderPath, "01.3 - EMAILCLIENTE.txt");

                    if (cbCliente.Checked == true)
                    {
                        await Task.Run(() => minhaQuerry.Cliente(client));
                        await Task.Run(() => minhaQuerry.Cliente_Endereco(clientendereco));
                        await Task.Run(() => minhaQuerry.Cliente_Telefone(clientetelefone));
                        await Task.Run(() => minhaQuerry.Cliente_Email(clienteemail));
                    }

                    //fornecedor
                    if (cbFornecedor.Checked == true)
                    {
                        string fornecedor = Path.Combine(folderPath, "02 - FORNECEDOR.txt");
                        string fornecedorendereco = Path.Combine(folderPath, "02.1 - ENDERECOFORNECEDOR.txt");
                        string fornecedortelefone = Path.Combine(folderPath, "02.2 - TELEFONEFORNECEDOR.txt");
                        string fornecedoremail = Path.Combine(folderPath, "02.3 - EMAILFORNECEDOR.txt");
                        string fornecedorcontato = Path.Combine(folderPath, "02.4 - CONTATOFORNECEDOR.txt");

                        await Task.Run(() => minhaQuerry.Fornecedor(fornecedor));
                        await Task.Run(() => minhaQuerry.Fornecedor_Endereco(fornecedorendereco));
                        await Task.Run(() => minhaQuerry.Fornecedor_Telefone(fornecedortelefone));
                        await Task.Run(() => minhaQuerry.Fornecedor_Email(fornecedoremail));
                        await Task.Run(() => minhaQuerry.Fornecedor_Contato(fornecedorcontato));
                    }

                    //NCMS E CESTS
                    string ncm = Path.Combine(folderPath, "04 - NCMFISCAL.txt");
                    string cest = Path.Combine(folderPath, "03 - CESTFISCAL.txt");
                    string cestxncm = Path.Combine(folderPath, "05 - CESTFISCALXNCMFISCAL.txt");
                    string markup = Path.Combine(folderPath, "06 - MARKUP.txt");

                    await Task.Run(() => minhaQuerry.cest(cest));
                    await Task.Run(() => minhaQuerry.ncm(ncm));
                    await Task.Run(() => minhaQuerry.cestxncm(cestxncm));
                    await Task.Run(() => minhaQuerry.markup(markup));

                    //cadastros de unidade,marca e grupo
                    string unidade = Path.Combine(folderPath, "07 - UNIDADES.txt");
                    string marca = Path.Combine(folderPath, "08 - MARCAS.txt");
                    string grupo = Path.Combine(folderPath, "09 - GRUPOS.txt");
                    string grade = Path.Combine(folderPath, "10 - GRADES.txt");

                    await Task.Run(() => minhaQuerry.Unidade(unidade));
                    await Task.Run(() => minhaQuerry.Marca(marca));
                    await Task.Run(() => minhaQuerry.Grupo(grupo));
                    await Task.Run(() => minhaQuerry.Grades(grade));

                    //cadastro de produtos
                    string produto = Path.Combine(folderPath, "11 - PRODUTOS.txt");
                    string saldo = Path.Combine(folderPath, "11.1 - PRECOS PRODUTOS.txt");
                    string gradeproduto = Path.Combine(folderPath, "11.2 - GRADES PRODUTOS.TXT");
                    string codigobarra = Path.Combine(folderPath, "11.3 - CODIGOSBARRASPRODUTO.txt");
                    string codigoterceiro = Path.Combine(folderPath, "11.4 - CODIGOSTERCEIROSPRODUTO.txt");

                    if (cbProduto.Checked == true)
                    {
                        await Task.Run(() => minhaQuerry.Produto(produto));

                        if (cbFilial1.Checked)
                        {
                            await Task.Run(() => minhaQuerry.Saldo(saldo, "1"));
                        }
                        else if (cbFilial2.Checked)
                        {
                            await Task.Run(() => minhaQuerry.Saldo(saldo, "2"));
                        }
                        else if (txtFilial.Text.Length > 0)
                        {
                            await Task.Run(() => minhaQuerry.Saldo(saldo, filialescolhida));
                        }
                        else
                        {
                            await Task.Run(() => minhaQuerry.Saldo(saldo));
                        }

                        if (cbSaldoZerado.Checked)
                        {
                            await Task.Run(() => minhaQuerry.GradeProdutoZerado(gradeproduto));
                        }
                        else if (cbFilial1.Checked)
                        {
                            await Task.Run(() => minhaQuerry.GradeProduto(gradeproduto, "1"));
                        }
                        else if (cbFilial2.Checked)
                        {
                            await Task.Run(() => minhaQuerry.GradeProduto(gradeproduto, "2"));
                        }
                        else if (txtFilial.Text.Length > 0)
                        {
                            await Task.Run(() => minhaQuerry.GradeProduto(gradeproduto, filialescolhida));
                        }
                        else
                        {
                            await Task.Run(() => minhaQuerry.GradeProduto(gradeproduto));
                        }
                    }

                    if (cbCodbar.Checked == true)
                    {
                        await Task.Run(() => minhaQuerry.CodigoBarra(codigobarra));
                    }

                    await Task.Run(() => minhaQuerry.CodigoTerceiro(codigoterceiro));

                    //documento financeiro
                    if (cbClidoc.Checked == true)
                    {
                        string clidoc = Path.Combine(folderPath, "12.1 - DOCUMENTOFINANCEIROCLIENTE.txt");

                        if (cbFilial1.Checked)
                        {
                            await Task.Run(() => minhaQuerry.Clidoc(clidoc, "1"));
                        }
                        else if (cbFilial2.Checked)
                        {
                            await Task.Run(() => minhaQuerry.Clidoc(clidoc, "2"));
                        }
                        else if (txtFilial.Text.Length > 0)
                        {
                            await Task.Run(() => minhaQuerry.Clidoc(clidoc, filialescolhida));
                        }
                        else
                        {
                            await Task.Run(() => minhaQuerry.Clidoc(clidoc));
                        }
                    }

                    if (cbFordoc.Checked == true)
                    {
                        string fordoc = Path.Combine(folderPath, "12.2 - DOCUMENTOFINANCEIROFORNECEDOR.txt");

                        if (cbFilial1.Checked)
                        {
                            await Task.Run(() => minhaQuerry.Fordoc(fordoc, "1"));
                        }
                        else if (cbFilial2.Checked)
                        {
                            await Task.Run(() => minhaQuerry.Fordoc(fordoc, "2"));
                        }
                        else if (txtFilial.Text.Length > 0)
                        {
                            await Task.Run(() => minhaQuerry.Fordoc(fordoc, filialescolhida));
                        }
                        else
                        {
                            await Task.Run(() => minhaQuerry.Fordoc(fordoc));
                        }
                    }

                    MessageBox.Show("Arquivos gerados");
                    FecharTodasConexoes();

                }
                else
                {
                    MessageBox.Show("Selecione um diretorio valido");
                    FolderBrowserDialog dlg = new FolderBrowserDialog();
                    dlg.ShowDialog();
                    txtDiretorio.Text = dlg.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void cbFilial2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilial2.Checked) { txtFilial.ReadOnly = true; cbFilial1.Checked = false; } 
            DesbloquearTextBoxFilial();
        }

        private void cbFilial1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilial1.Checked) { txtFilial.ReadOnly = true; cbFilial2.Checked = false; } 
            DesbloquearTextBoxFilial();

        }

        private void DesbloquearTextBoxFilial() 
        {
            if (cbFilial1.Checked == false && cbFilial2.Checked == false) { txtFilial.ReadOnly = false; }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void FecharTodasConexoes()
        {
            foreach (SqlConnection conn in conexoesAbertas)
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                    MessageBox.Show("Conexão fechada.");
                }
            }

            // Limpa a lista de conexões
            conexoesAbertas.Clear();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo completamente
        }
    }
}
