using System.Windows.Forms;

namespace ProjetoCriadorDePasta
{
    partial class Tela
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela));
            this.Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomePasta = new System.Windows.Forms.TextBox();
            this.rbVarejo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbWEB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAlterData = new System.Windows.Forms.RadioButton();
            this.rbUniplus = new System.Windows.Forms.RadioButton();
            this.rbAtual = new System.Windows.Forms.RadioButton();
            this.rbNewProject = new System.Windows.Forms.RadioButton();
            this.btCriarPasta = new System.Windows.Forms.Button();
            this.btAbrirQuerry = new System.Windows.Forms.Button();
            this.btnStringConexão = new System.Windows.Forms.Button();
            this.BtnCaminhoDiretorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.Transparent;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(135, 18);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(270, 50);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Criação de diretorio";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o nome da pasta:";
            // 
            // NomePasta
            // 
            this.NomePasta.Location = new System.Drawing.Point(192, 90);
            this.NomePasta.Name = "NomePasta";
            this.NomePasta.Size = new System.Drawing.Size(368, 20);
            this.NomePasta.TabIndex = 2;
            this.NomePasta.TextChanged += new System.EventHandler(this.nomePastaPrincipal_TextChanged);
            // 
            // rbVarejo
            // 
            this.rbVarejo.BackColor = System.Drawing.Color.Transparent;
            this.rbVarejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVarejo.Location = new System.Drawing.Point(267, 139);
            this.rbVarejo.Name = "rbVarejo";
            this.rbVarejo.Size = new System.Drawing.Size(80, 16);
            this.rbVarejo.TabIndex = 3;
            this.rbVarejo.TabStop = true;
            this.rbVarejo.Text = "VAREJO";
            this.rbVarejo.UseVisualStyleBackColor = false;
            this.rbVarejo.Visible = false;
            this.rbVarejo.CheckedChanged += new System.EventHandler(this.rbVarejo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para onde vai ser migrado?";
            // 
            // rbWEB
            // 
            this.rbWEB.BackColor = System.Drawing.Color.Transparent;
            this.rbWEB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWEB.Location = new System.Drawing.Point(208, 139);
            this.rbWEB.Name = "rbWEB";
            this.rbWEB.Size = new System.Drawing.Size(53, 16);
            this.rbWEB.TabIndex = 5;
            this.rbWEB.TabStop = true;
            this.rbWEB.Text = "WEB";
            this.rbWEB.UseVisualStyleBackColor = false;
            this.rbWEB.CheckedChanged += new System.EventHandler(this.rbWEB_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selecione o software original do banco:";
            this.label4.Visible = false;
            // 
            // rbAlterData
            // 
            this.rbAlterData.BackColor = System.Drawing.Color.Transparent;
            this.rbAlterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlterData.Location = new System.Drawing.Point(1, 225);
            this.rbAlterData.Name = "rbAlterData";
            this.rbAlterData.Size = new System.Drawing.Size(97, 16);
            this.rbAlterData.TabIndex = 8;
            this.rbAlterData.TabStop = true;
            this.rbAlterData.Text = "ALTERDATA";
            this.rbAlterData.UseVisualStyleBackColor = false;
            this.rbAlterData.Visible = false;
            this.rbAlterData.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbUniplus
            // 
            this.rbUniplus.BackColor = System.Drawing.Color.Transparent;
            this.rbUniplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUniplus.Location = new System.Drawing.Point(1, 247);
            this.rbUniplus.Name = "rbUniplus";
            this.rbUniplus.Size = new System.Drawing.Size(80, 16);
            this.rbUniplus.TabIndex = 9;
            this.rbUniplus.TabStop = true;
            this.rbUniplus.Text = "UNIPLUS";
            this.rbUniplus.UseVisualStyleBackColor = false;
            this.rbUniplus.Visible = false;
            this.rbUniplus.CheckedChanged += new System.EventHandler(this.rbUniplus_CheckedChanged);
            // 
            // rbAtual
            // 
            this.rbAtual.BackColor = System.Drawing.Color.Transparent;
            this.rbAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtual.Location = new System.Drawing.Point(1, 269);
            this.rbAtual.Name = "rbAtual";
            this.rbAtual.Size = new System.Drawing.Size(133, 16);
            this.rbAtual.TabIndex = 10;
            this.rbAtual.TabStop = true;
            this.rbAtual.Text = "ATUAL SISTEMAS";
            this.rbAtual.UseVisualStyleBackColor = false;
            this.rbAtual.Visible = false;
            this.rbAtual.CheckedChanged += new System.EventHandler(this.rbAtual_CheckedChanged);
            // 
            // rbNewProject
            // 
            this.rbNewProject.BackColor = System.Drawing.Color.Transparent;
            this.rbNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewProject.Location = new System.Drawing.Point(1, 291);
            this.rbNewProject.Name = "rbNewProject";
            this.rbNewProject.Size = new System.Drawing.Size(133, 16);
            this.rbNewProject.TabIndex = 11;
            this.rbNewProject.TabStop = true;
            this.rbNewProject.Text = "PROJETO NOVO";
            this.rbNewProject.UseVisualStyleBackColor = false;
            this.rbNewProject.Visible = false;
            this.rbNewProject.CheckedChanged += new System.EventHandler(this.rbNewProject_CheckedChanged);
            // 
            // btCriarPasta
            // 
            this.btCriarPasta.BackColor = System.Drawing.Color.White;
            this.btCriarPasta.Location = new System.Drawing.Point(192, 325);
            this.btCriarPasta.Name = "btCriarPasta";
            this.btCriarPasta.Size = new System.Drawing.Size(158, 50);
            this.btCriarPasta.TabIndex = 12;
            this.btCriarPasta.Text = "CRIAR DIRETORIO";
            this.btCriarPasta.UseVisualStyleBackColor = false;
            this.btCriarPasta.Click += new System.EventHandler(this.btCriarPasta_Click);
            // 
            // btAbrirQuerry
            // 
            this.btAbrirQuerry.BackColor = System.Drawing.Color.White;
            this.btAbrirQuerry.Location = new System.Drawing.Point(459, 276);
            this.btAbrirQuerry.Name = "btAbrirQuerry";
            this.btAbrirQuerry.Size = new System.Drawing.Size(90, 46);
            this.btAbrirQuerry.TabIndex = 14;
            this.btAbrirQuerry.Text = "QUERRY WEB";
            this.btAbrirQuerry.UseVisualStyleBackColor = false;
            this.btAbrirQuerry.Click += new System.EventHandler(this.btAbrirQuerry_Click);
            // 
            // btnStringConexão
            // 
            this.btnStringConexão.BackColor = System.Drawing.Color.White;
            this.btnStringConexão.Location = new System.Drawing.Point(459, 217);
            this.btnStringConexão.Name = "btnStringConexão";
            this.btnStringConexão.Size = new System.Drawing.Size(90, 46);
            this.btnStringConexão.TabIndex = 15;
            this.btnStringConexão.Text = "CONFIGURAR CONEXÃO";
            this.btnStringConexão.UseVisualStyleBackColor = false;
            this.btnStringConexão.Click += new System.EventHandler(this.btnStringConexão_Click);
            // 
            // BtnCaminhoDiretorio
            // 
            this.BtnCaminhoDiretorio.BackColor = System.Drawing.Color.White;
            this.BtnCaminhoDiretorio.Location = new System.Drawing.Point(459, 162);
            this.BtnCaminhoDiretorio.Name = "BtnCaminhoDiretorio";
            this.BtnCaminhoDiretorio.Size = new System.Drawing.Size(90, 46);
            this.BtnCaminhoDiretorio.TabIndex = 16;
            this.BtnCaminhoDiretorio.Text = "CAMINHO DIRETORIO";
            this.BtnCaminhoDiretorio.UseVisualStyleBackColor = false;
            this.BtnCaminhoDiretorio.Click += new System.EventHandler(this.BtnCaminhoDiretorio_Click);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.logo;
            this.ClientSize = new System.Drawing.Size(561, 391);
            this.Controls.Add(this.BtnCaminhoDiretorio);
            this.Controls.Add(this.btnStringConexão);
            this.Controls.Add(this.btAbrirQuerry);
            this.Controls.Add(this.btCriarPasta);
            this.Controls.Add(this.rbNewProject);
            this.Controls.Add(this.rbAtual);
            this.Controls.Add(this.rbUniplus);
            this.Controls.Add(this.rbAlterData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbWEB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbVarejo);
            this.Controls.Add(this.NomePasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela";
            this.Text = "MigradorWEB";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomePasta;
        private System.Windows.Forms.RadioButton rbVarejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbWEB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbAlterData;
        private System.Windows.Forms.RadioButton rbUniplus;
        private System.Windows.Forms.RadioButton rbAtual;
        private System.Windows.Forms.RadioButton rbNewProject;
        private System.Windows.Forms.Button btCriarPasta;
        private System.Windows.Forms.Button btAbrirQuerry;
        private System.Windows.Forms.Button btnStringConexão;
        private System.Windows.Forms.Button BtnCaminhoDiretorio;
    }
}

