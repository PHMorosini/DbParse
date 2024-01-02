namespace ProjetoCriadorDePasta
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CadastrarProjeto = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o nome do banco:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o nome do autor:";
            // 
            // CadastrarProjeto
            // 
            this.CadastrarProjeto.BackColor = System.Drawing.Color.Red;
            this.CadastrarProjeto.Location = new System.Drawing.Point(181, 125);
            this.CadastrarProjeto.Name = "CadastrarProjeto";
            this.CadastrarProjeto.Size = new System.Drawing.Size(192, 43);
            this.CadastrarProjeto.TabIndex = 7;
            this.CadastrarProjeto.Text = "CADASTRAR";
            this.CadastrarProjeto.UseVisualStyleBackColor = false;
            this.CadastrarProjeto.Click += new System.EventHandler(this.CadastrarProjeto_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(171, 67);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(378, 20);
            this.txtNomeAutor.TabIndex = 8;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(170, 27);
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(378, 20);
            this.txtNomeBanco.TabIndex = 9;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 195);
            this.Controls.Add(this.txtNomeBanco);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.CadastrarProjeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastro";
            this.Text = "Adicionar novo projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CadastrarProjeto;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtNomeBanco;
    }
}