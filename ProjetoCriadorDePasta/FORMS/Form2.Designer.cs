namespace ProjetoCriadorDePasta
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProjetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetosCriadosVarejoDataSet1 = new ProjetoCriadorDePasta.ProjetosCriadosVarejoDataSet1();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btCadastrarProjeto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeBusca = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.projetosCriadosVarejoDataSet = new ProjetoCriadorDePasta.ProjetosCriadosVarejoDataSet();
            this.projetosCriadosVarejoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeProjetoTableAdapter = new ProjetoCriadorDePasta.ProjetosCriadosVarejoDataSet1TableAdapters.NomeProjetoTableAdapter();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeProjetoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosCriadosVarejoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosCriadosVarejoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosCriadosVarejoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de projetos já criados";
            this.label1.Visible = false;
            // 
            // dgTabela
            // 
            this.dgTabela.AllowUserToAddRows = false;
            this.dgTabela.AllowUserToResizeColumns = false;
            this.dgTabela.AllowUserToResizeRows = false;
            this.dgTabela.AutoGenerateColumns = false;
            this.dgTabela.BackgroundColor = System.Drawing.Color.White;
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.criadorDataGridViewTextBoxColumn});
            this.dgTabela.DataSource = this.nomeProjetoBindingSource;
            this.dgTabela.Location = new System.Drawing.Point(67, 106);
            this.dgTabela.MultiSelect = false;
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.ReadOnly = true;
            this.dgTabela.Size = new System.Drawing.Size(424, 196);
            this.dgTabela.TabIndex = 1;
            this.dgTabela.Visible = false;
            this.dgTabela.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.iDDataGridViewTextBoxColumn.Width = 30;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // criadorDataGridViewTextBoxColumn
            // 
            this.criadorDataGridViewTextBoxColumn.DataPropertyName = "Criador";
            this.criadorDataGridViewTextBoxColumn.HeaderText = "Criador";
            this.criadorDataGridViewTextBoxColumn.Name = "criadorDataGridViewTextBoxColumn";
            this.criadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.criadorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.criadorDataGridViewTextBoxColumn.Width = 200;
            // 
            // nomeProjetoBindingSource
            // 
            this.nomeProjetoBindingSource.DataMember = "NomeProjeto";
            this.nomeProjetoBindingSource.DataSource = this.projetosCriadosVarejoDataSet1;
            // 
            // projetosCriadosVarejoDataSet1
            // 
            this.projetosCriadosVarejoDataSet1.DataSetName = "ProjetosCriadosVarejoDataSet1";
            this.projetosCriadosVarejoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.White;
            this.btVoltar.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.kyogre;
            this.btVoltar.Location = new System.Drawing.Point(418, 335);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(113, 33);
            this.btVoltar.TabIndex = 3;
            this.btVoltar.Text = "Retornar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Visible = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btCadastrarProjeto
            // 
            this.btCadastrarProjeto.BackColor = System.Drawing.Color.White;
            this.btCadastrarProjeto.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.kyogre;
            this.btCadastrarProjeto.Location = new System.Drawing.Point(30, 325);
            this.btCadastrarProjeto.Name = "btCadastrarProjeto";
            this.btCadastrarProjeto.Size = new System.Drawing.Size(150, 43);
            this.btCadastrarProjeto.TabIndex = 4;
            this.btCadastrarProjeto.Text = "Cadastrar novo projeto";
            this.btCadastrarProjeto.UseVisualStyleBackColor = false;
            this.btCadastrarProjeto.Visible = false;
            this.btCadastrarProjeto.Click += new System.EventHandler(this.btCadastrarProjeto_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "NOME:";
            this.label2.Visible = false;
            // 
            // txtNomeBusca
            // 
            this.txtNomeBusca.Location = new System.Drawing.Point(97, 68);
            this.txtNomeBusca.Name = "txtNomeBusca";
            this.txtNomeBusca.Size = new System.Drawing.Size(367, 20);
            this.txtNomeBusca.TabIndex = 6;
            this.txtNomeBusca.Visible = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.White;
            this.btBuscar.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.kyogre;
            this.btBuscar.Location = new System.Drawing.Point(470, 66);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(71, 22);
            this.btBuscar.TabIndex = 7;
            this.btBuscar.Text = "Pesquisar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Visible = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // projetosCriadosVarejoDataSet
            // 
            this.projetosCriadosVarejoDataSet.DataSetName = "ProjetosCriadosVarejoDataSet";
            this.projetosCriadosVarejoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projetosCriadosVarejoDataSetBindingSource
            // 
            this.projetosCriadosVarejoDataSetBindingSource.DataSource = this.projetosCriadosVarejoDataSet;
            this.projetosCriadosVarejoDataSetBindingSource.Position = 0;
            // 
            // nomeProjetoTableAdapter
            // 
            this.nomeProjetoTableAdapter.ClearBeforeFill = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(197, 237);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(169, 48);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.btConectarBanco_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(216, 119);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(248, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(216, 153);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(248, 20);
            this.TxtSenha.TabIndex = 11;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.Logo01;
            this.ClientSize = new System.Drawing.Size(561, 391);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txtNomeBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCadastrarProjeto);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.dgTabela);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Listagem de projetos já criados";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomeProjetoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosCriadosVarejoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosCriadosVarejoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetosCriadosVarejoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.BindingSource projetosCriadosVarejoDataSetBindingSource;
        private ProjetosCriadosVarejoDataSet projetosCriadosVarejoDataSet;
        private ProjetosCriadosVarejoDataSet1 projetosCriadosVarejoDataSet1;
        private System.Windows.Forms.BindingSource nomeProjetoBindingSource;
        private ProjetosCriadosVarejoDataSet1TableAdapters.NomeProjetoTableAdapter nomeProjetoTableAdapter;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btCadastrarProjeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeBusca;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn criadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSenha;
    }
}