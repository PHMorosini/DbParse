namespace ProjetoCriadorDePasta.FORMS
{
    partial class FrmStringBuilder
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
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnCriarString = new System.Windows.Forms.Button();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(118, 31);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(292, 20);
            this.txtServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SERVER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "USER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "DATABASE:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(292, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(118, 91);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(292, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(118, 63);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(292, 20);
            this.txtDatabase.TabIndex = 1;
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRetornar.Location = new System.Drawing.Point(179, 215);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(109, 54);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.Text = "RETORNAR";
            this.btnRetornar.UseVisualStyleBackColor = false;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnCriarString
            // 
            this.btnCriarString.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCriarString.Location = new System.Drawing.Point(53, 215);
            this.btnCriarString.Name = "btnCriarString";
            this.btnCriarString.Size = new System.Drawing.Size(109, 54);
            this.btnCriarString.TabIndex = 9;
            this.btnCriarString.Text = "CRIAR STRING";
            this.btnCriarString.UseVisualStyleBackColor = false;
            this.btnCriarString.Click += new System.EventHandler(this.btnCriarString_Click);
            // 
            // txtSecurity
            // 
            this.txtSecurity.Location = new System.Drawing.Point(118, 164);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.Size = new System.Drawing.Size(292, 20);
            this.txtSecurity.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SECURITY:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeste.Location = new System.Drawing.Point(306, 215);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(109, 54);
            this.btnTeste.TabIndex = 12;
            this.btnTeste.Text = "TESTAR";
            this.btnTeste.UseVisualStyleBackColor = false;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // FrmStringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoCriadorDePasta.Properties.Resources.Logo01;
            this.ClientSize = new System.Drawing.Size(447, 281);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.txtSecurity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCriarString);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStringBuilder";
            this.Text = "FrmStringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnCriarString;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTeste;
    }
}