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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSomenteFilial2 = new System.Windows.Forms.RadioButton();
            this.rbSomenteFilial1 = new System.Windows.Forms.RadioButton();
            this.rbSemSaldo = new System.Windows.Forms.RadioButton();
            this.btGerarArquivos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConectarBanco
            // 
            this.btConectarBanco.BackColor = System.Drawing.Color.White;
            this.btConectarBanco.Location = new System.Drawing.Point(419, 297);
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
            this.btVoltar.Location = new System.Drawing.Point(419, 336);
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
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbSomenteFilial2);
            this.panel1.Controls.Add(this.rbSomenteFilial1);
            this.panel1.Controls.Add(this.rbSemSaldo);
            this.panel1.Location = new System.Drawing.Point(27, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 265);
            this.panel1.TabIndex = 8;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 10;
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
            // rbSomenteFilial2
            // 
            this.rbSomenteFilial2.AutoSize = true;
            this.rbSomenteFilial2.Location = new System.Drawing.Point(17, 91);
            this.rbSomenteFilial2.Name = "rbSomenteFilial2";
            this.rbSomenteFilial2.Size = new System.Drawing.Size(96, 17);
            this.rbSomenteFilial2.TabIndex = 2;
            this.rbSomenteFilial2.TabStop = true;
            this.rbSomenteFilial2.Text = "Somente filial 2";
            this.rbSomenteFilial2.UseVisualStyleBackColor = true;
            // 
            // rbSomenteFilial1
            // 
            this.rbSomenteFilial1.AutoSize = true;
            this.rbSomenteFilial1.Location = new System.Drawing.Point(17, 68);
            this.rbSomenteFilial1.Name = "rbSomenteFilial1";
            this.rbSomenteFilial1.Size = new System.Drawing.Size(96, 17);
            this.rbSomenteFilial1.TabIndex = 1;
            this.rbSomenteFilial1.TabStop = true;
            this.rbSomenteFilial1.Text = "Somente filial 1";
            this.rbSomenteFilial1.UseVisualStyleBackColor = true;
            this.rbSomenteFilial1.CheckedChanged += new System.EventHandler(this.rbSomenteFilial1_CheckedChanged);
            // 
            // rbSemSaldo
            // 
            this.rbSemSaldo.AutoSize = true;
            this.rbSemSaldo.Location = new System.Drawing.Point(17, 45);
            this.rbSemSaldo.Name = "rbSemSaldo";
            this.rbSemSaldo.Size = new System.Drawing.Size(87, 17);
            this.rbSemSaldo.TabIndex = 0;
            this.rbSemSaldo.TabStop = true;
            this.rbSemSaldo.Text = "Saldo zerado";
            this.rbSemSaldo.UseVisualStyleBackColor = true;
            this.rbSemSaldo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btGerarArquivos
            // 
            this.btGerarArquivos.BackColor = System.Drawing.Color.White;
            this.btGerarArquivos.Location = new System.Drawing.Point(303, 149);
            this.btGerarArquivos.Name = "btGerarArquivos";
            this.btGerarArquivos.Size = new System.Drawing.Size(134, 52);
            this.btGerarArquivos.TabIndex = 9;
            this.btGerarArquivos.Text = "Gerar Arquivos";
            this.btGerarArquivos.UseVisualStyleBackColor = false;
            this.btGerarArquivos.Click += new System.EventHandler(this.btGerarArquivos_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.Logo01;
            this.ClientSize = new System.Drawing.Size(551, 423);
            this.Controls.Add(this.btGerarArquivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btPesquisaDiretorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btConectarBanco);
            this.Name = "Form3";
            this.Text = "Querry WEB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbSomenteFilial1;
        private System.Windows.Forms.RadioButton rbSemSaldo;
        private System.Windows.Forms.RadioButton rbSomenteFilial2;
        private System.Windows.Forms.Button btGerarArquivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}