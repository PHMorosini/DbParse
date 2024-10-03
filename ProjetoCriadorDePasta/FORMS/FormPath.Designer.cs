namespace ProjetoCriadorDePasta.FORMS
{
    partial class FormPath
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btPesquisaDiretorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.White;
            this.btVoltar.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.kyogre;
            this.btVoltar.Location = new System.Drawing.Point(176, 129);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(113, 33);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "Retornar";
            this.btVoltar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.White;
            this.BtnSalvar.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.kyogre;
            this.BtnSalvar.Location = new System.Drawing.Point(31, 129);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(113, 33);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(12, 73);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.ReadOnly = true;
            this.txtDiretorio.Size = new System.Drawing.Size(219, 20);
            this.txtDiretorio.TabIndex = 7;
            // 
            // btPesquisaDiretorio
            // 
            this.btPesquisaDiretorio.BackColor = System.Drawing.Color.White;
            this.btPesquisaDiretorio.Location = new System.Drawing.Point(237, 73);
            this.btPesquisaDiretorio.Name = "btPesquisaDiretorio";
            this.btPesquisaDiretorio.Size = new System.Drawing.Size(80, 20);
            this.btPesquisaDiretorio.TabIndex = 8;
            this.btPesquisaDiretorio.Text = "PESQUISAR";
            this.btPesquisaDiretorio.UseVisualStyleBackColor = false;
            this.btPesquisaDiretorio.Click += new System.EventHandler(this.btPesquisaDiretorio_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione o diretorio:";
            // 
            // FormPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPesquisaDiretorio);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.btVoltar);
            this.Name = "FormPath";
            this.Text = "FormPath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Button btPesquisaDiretorio;
        private System.Windows.Forms.Label label1;
    }
}