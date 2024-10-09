namespace ProjetoCriadorDePasta.FORMS
{
    partial class FormDirectoryPatch
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
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.btPesquisaDiretorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btPesquisaDiretorio2 = new System.Windows.Forms.Button();
            this.txtDiretorio2 = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(172, 12);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.ReadOnly = true;
            this.txtDiretorio.Size = new System.Drawing.Size(230, 20);
            this.txtDiretorio.TabIndex = 6;
            // 
            // btPesquisaDiretorio
            // 
            this.btPesquisaDiretorio.BackColor = System.Drawing.Color.White;
            this.btPesquisaDiretorio.Location = new System.Drawing.Point(408, 12);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pasta a ser copiada:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Onde vai ser criada:";
            // 
            // btPesquisaDiretorio2
            // 
            this.btPesquisaDiretorio2.BackColor = System.Drawing.Color.White;
            this.btPesquisaDiretorio2.Location = new System.Drawing.Point(408, 52);
            this.btPesquisaDiretorio2.Name = "btPesquisaDiretorio2";
            this.btPesquisaDiretorio2.Size = new System.Drawing.Size(80, 20);
            this.btPesquisaDiretorio2.TabIndex = 11;
            this.btPesquisaDiretorio2.Text = "PESQUISAR";
            this.btPesquisaDiretorio2.UseVisualStyleBackColor = false;
            this.btPesquisaDiretorio2.Click += new System.EventHandler(this.btPesquisaDiretorio2_Click);
            // 
            // txtDiretorio2
            // 
            this.txtDiretorio2.Location = new System.Drawing.Point(172, 52);
            this.txtDiretorio2.Name = "txtDiretorio2";
            this.txtDiretorio2.ReadOnly = true;
            this.txtDiretorio2.Size = new System.Drawing.Size(230, 20);
            this.txtDiretorio2.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(172, 93);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 48);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormDirectoryPatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 153);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPesquisaDiretorio2);
            this.Controls.Add(this.txtDiretorio2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPesquisaDiretorio);
            this.Controls.Add(this.txtDiretorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDirectoryPatch";
            this.Text = "MigradorWEB";
            this.Load += new System.EventHandler(this.FormDirectoryPatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.Button btPesquisaDiretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPesquisaDiretorio2;
        private System.Windows.Forms.TextBox txtDiretorio2;
        private System.Windows.Forms.Button btnSalvar;
    }
}