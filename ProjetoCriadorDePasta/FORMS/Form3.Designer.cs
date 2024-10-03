namespace ProjetoCriadorDePasta.FORMS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConectarBanco = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btPesquisaDiretorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilial2 = new System.Windows.Forms.CheckBox();
            this.cbFilial1 = new System.Windows.Forms.CheckBox();
            this.cbSaldoZerado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGerarArquivos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.cbFornecedor = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFordoc = new System.Windows.Forms.CheckBox();
            this.cbClidoc = new System.Windows.Forms.CheckBox();
            this.cbCodbar = new System.Windows.Forms.CheckBox();
            this.cbProduto = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConectarBanco
            // 
            this.btConectarBanco.BackColor = System.Drawing.Color.White;
            this.btConectarBanco.Location = new System.Drawing.Point(419, 336);
            this.btConectarBanco.Name = "btConectarBanco";
            this.btConectarBanco.Size = new System.Drawing.Size(113, 33);
            this.btConectarBanco.TabIndex = 0;
            this.btConectarBanco.Text = "Testar conexão";
            this.btConectarBanco.UseVisualStyleBackColor = false;
            this.btConectarBanco.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.White;
            this.btVoltar.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.kyogre;
            this.btVoltar.Location = new System.Drawing.Point(419, 378);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(113, 33);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Retornar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click_1);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(202, 34);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.ReadOnly = true;
            this.txtDiretorio.Size = new System.Drawing.Size(261, 20);
            this.txtDiretorio.TabIndex = 5;
            this.txtDiretorio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o diretorio:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btPesquisaDiretorio
            // 
            this.btPesquisaDiretorio.BackColor = System.Drawing.Color.White;
            this.btPesquisaDiretorio.Location = new System.Drawing.Point(469, 34);
            this.btPesquisaDiretorio.Name = "btPesquisaDiretorio";
            this.btPesquisaDiretorio.Size = new System.Drawing.Size(80, 20);
            this.btPesquisaDiretorio.TabIndex = 7;
            this.btPesquisaDiretorio.Text = "PESQUISAR";
            this.btPesquisaDiretorio.UseVisualStyleBackColor = false;
            this.btPesquisaDiretorio.Click += new System.EventHandler(this.btPesquisaDiretorio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbFilial2);
            this.panel1.Controls.Add(this.cbFilial1);
            this.panel1.Controls.Add(this.cbSaldoZerado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFilial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(240, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 159);
            this.panel1.TabIndex = 8;
            // 
            // cbFilial2
            // 
            this.cbFilial2.AutoSize = true;
            this.cbFilial2.Location = new System.Drawing.Point(16, 88);
            this.cbFilial2.Name = "cbFilial2";
            this.cbFilial2.Size = new System.Drawing.Size(97, 17);
            this.cbFilial2.TabIndex = 13;
            this.cbFilial2.Text = "Somente filial 2";
            this.cbFilial2.UseVisualStyleBackColor = true;
            this.cbFilial2.CheckedChanged += new System.EventHandler(this.cbFilial2_CheckedChanged);
            // 
            // cbFilial1
            // 
            this.cbFilial1.AutoSize = true;
            this.cbFilial1.Location = new System.Drawing.Point(16, 68);
            this.cbFilial1.Name = "cbFilial1";
            this.cbFilial1.Size = new System.Drawing.Size(97, 17);
            this.cbFilial1.TabIndex = 12;
            this.cbFilial1.Text = "Somente filial 1";
            this.cbFilial1.UseVisualStyleBackColor = true;
            this.cbFilial1.CheckedChanged += new System.EventHandler(this.cbFilial1_CheckedChanged);
            // 
            // cbSaldoZerado
            // 
            this.cbSaldoZerado.AutoSize = true;
            this.cbSaldoZerado.Location = new System.Drawing.Point(16, 45);
            this.cbSaldoZerado.Name = "cbSaldoZerado";
            this.cbSaldoZerado.Size = new System.Drawing.Size(88, 17);
            this.cbSaldoZerado.TabIndex = 11;
            this.cbSaldoZerado.Text = "Saldo zerado";
            this.cbSaldoZerado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite a filial:";
            // 
            // txtFilial
            // 
            this.txtFilial.Location = new System.Drawing.Point(99, 111);
            this.txtFilial.Name = "txtFilial";
            this.txtFilial.Size = new System.Drawing.Size(70, 20);
            this.txtFilial.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtros extras:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btGerarArquivos
            // 
            this.btGerarArquivos.BackColor = System.Drawing.Color.White;
            this.btGerarArquivos.Location = new System.Drawing.Point(39, 282);
            this.btGerarArquivos.Name = "btGerarArquivos";
            this.btGerarArquivos.Size = new System.Drawing.Size(134, 52);
            this.btGerarArquivos.TabIndex = 9;
            this.btGerarArquivos.Text = "Gerar Arquivos";
            this.btGerarArquivos.UseVisualStyleBackColor = false;
            this.btGerarArquivos.Click += new System.EventHandler(this.btGerarArquivos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "A migrar:";
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(3, 39);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(71, 17);
            this.cbCliente.TabIndex = 13;
            this.cbCliente.Text = "CLIENTE";
            this.cbCliente.UseVisualStyleBackColor = true;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoSize = true;
            this.cbFornecedor.Location = new System.Drawing.Point(3, 59);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(101, 17);
            this.cbFornecedor.TabIndex = 14;
            this.cbFornecedor.Text = "FORNECEDOR";
            this.cbFornecedor.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.cbFordoc);
            this.panel2.Controls.Add(this.cbClidoc);
            this.panel2.Controls.Add(this.cbCodbar);
            this.panel2.Controls.Add(this.cbProduto);
            this.panel2.Controls.Add(this.cbFornecedor);
            this.panel2.Controls.Add(this.cbCliente);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(14, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 172);
            this.panel2.TabIndex = 10;
            // 
            // cbFordoc
            // 
            this.cbFordoc.AutoSize = true;
            this.cbFordoc.Location = new System.Drawing.Point(3, 151);
            this.cbFordoc.Name = "cbFordoc";
            this.cbFordoc.Size = new System.Drawing.Size(71, 17);
            this.cbFordoc.TabIndex = 18;
            this.cbFordoc.Text = "FORDOC";
            this.cbFordoc.UseVisualStyleBackColor = true;
            // 
            // cbClidoc
            // 
            this.cbClidoc.AutoSize = true;
            this.cbClidoc.Location = new System.Drawing.Point(3, 128);
            this.cbClidoc.Name = "cbClidoc";
            this.cbClidoc.Size = new System.Drawing.Size(65, 17);
            this.cbClidoc.TabIndex = 17;
            this.cbClidoc.Text = "CLIDOC";
            this.cbClidoc.UseVisualStyleBackColor = true;
            this.cbClidoc.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // cbCodbar
            // 
            this.cbCodbar.AutoSize = true;
            this.cbCodbar.Location = new System.Drawing.Point(3, 105);
            this.cbCodbar.Name = "cbCodbar";
            this.cbCodbar.Size = new System.Drawing.Size(133, 17);
            this.cbCodbar.TabIndex = 16;
            this.cbCodbar.Text = "CODIGO DE BARRAS";
            this.cbCodbar.UseVisualStyleBackColor = true;
            // 
            // cbProduto
            // 
            this.cbProduto.AutoSize = true;
            this.cbProduto.Location = new System.Drawing.Point(3, 82);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(80, 17);
            this.cbProduto.TabIndex = 15;
            this.cbProduto.Text = "PRODUTO";
            this.cbProduto.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.Logo01;
            this.ClientSize = new System.Drawing.Size(551, 423);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btGerarArquivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btPesquisaDiretorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btConectarBanco);
            this.Name = "Form3";
            this.Text = "Querry WEB";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConectarBanco;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisaDiretorio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btGerarArquivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilial;
        private System.Windows.Forms.CheckBox cbSaldoZerado;
        private System.Windows.Forms.CheckBox cbFilial1;
        private System.Windows.Forms.CheckBox cbFilial2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.CheckBox cbFornecedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbClidoc;
        private System.Windows.Forms.CheckBox cbCodbar;
        private System.Windows.Forms.CheckBox cbProduto;
        private System.Windows.Forms.CheckBox cbFordoc;
    }
}