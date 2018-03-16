namespace dicionario
{
    partial class frm_controledeusuario
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
            this.txtusr = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRSoc = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.comboPermissao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label_usr = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_tel = new System.Windows.Forms.Label();
            this.label_permit = new System.Windows.Forms.Label();
            this.label_social = new System.Windows.Forms.Label();
            this.label_CPF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusr
            // 
            this.txtusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtusr.Location = new System.Drawing.Point(63, 83);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(182, 26);
            this.txtusr.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpass.Location = new System.Drawing.Point(62, 133);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(183, 26);
            this.txtpass.TabIndex = 1;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContato.Location = new System.Drawing.Point(62, 283);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(183, 26);
            this.txtContato.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(62, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(62, 233);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 26);
            this.txtNome.TabIndex = 3;
            // 
            // txtRSoc
            // 
            this.txtRSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRSoc.Location = new System.Drawing.Point(363, 183);
            this.txtRSoc.Name = "txtRSoc";
            this.txtRSoc.Size = new System.Drawing.Size(183, 26);
            this.txtRSoc.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCpf.Location = new System.Drawing.Point(363, 133);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(183, 26);
            this.txtCpf.TabIndex = 5;
            // 
            // comboPermissao
            // 
            this.comboPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboPermissao.FormattingEnabled = true;
            this.comboPermissao.Items.AddRange(new object[] {
            "ADM",
            "EDT",
            "USR"});
            this.comboPermissao.Location = new System.Drawing.Point(363, 81);
            this.comboPermissao.Name = "comboPermissao";
            this.comboPermissao.Size = new System.Drawing.Size(183, 28);
            this.comboPermissao.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(59, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Controle de Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(444, 283);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(102, 33);
            this.btnincluir.TabIndex = 8;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_usr.Location = new System.Drawing.Point(60, 62);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(60, 18);
            this.label_usr.TabIndex = 9;
            this.label_usr.Text = "Usuário";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_pass.Location = new System.Drawing.Point(60, 112);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(50, 18);
            this.label_pass.TabIndex = 10;
            this.label_pass.Text = "Senha";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_email.Location = new System.Drawing.Point(59, 162);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(50, 18);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "E-mail";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_name.Location = new System.Drawing.Point(60, 212);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 18);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Nome";
            // 
            // label_tel
            // 
            this.label_tel.AutoSize = true;
            this.label_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_tel.Location = new System.Drawing.Point(59, 262);
            this.label_tel.Name = "label_tel";
            this.label_tel.Size = new System.Drawing.Size(65, 18);
            this.label_tel.TabIndex = 13;
            this.label_tel.Text = "Telefone";
            // 
            // label_permit
            // 
            this.label_permit.AutoSize = true;
            this.label_permit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_permit.Location = new System.Drawing.Point(360, 60);
            this.label_permit.Name = "label_permit";
            this.label_permit.Size = new System.Drawing.Size(136, 18);
            this.label_permit.TabIndex = 14;
            this.label_permit.Text = "Nível de Permissão";
            this.label_permit.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_social
            // 
            this.label_social.AutoSize = true;
            this.label_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_social.Location = new System.Drawing.Point(360, 112);
            this.label_social.Name = "label_social";
            this.label_social.Size = new System.Drawing.Size(88, 18);
            this.label_social.TabIndex = 15;
            this.label_social.Text = "Rede Social";
            // 
            // label_CPF
            // 
            this.label_CPF.AutoSize = true;
            this.label_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_CPF.Location = new System.Drawing.Point(360, 162);
            this.label_CPF.Name = "label_CPF";
            this.label_CPF.Size = new System.Drawing.Size(38, 18);
            this.label_CPF.TabIndex = 16;
            this.label_CPF.Text = "CPF";
            this.label_CPF.Click += new System.EventHandler(this.label4_Click);
            // 
            // frm_controledeusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label_CPF);
            this.Controls.Add(this.label_social);
            this.Controls.Add(this.label_permit);
            this.Controls.Add(this.label_tel);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_usr);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPermissao);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRSoc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtusr);
            this.Name = "frm_controledeusuario";
            this.Text = "controledeusuario";
            this.Load += new System.EventHandler(this.frm_controledeusuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusr;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRSoc;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.ComboBox comboPermissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_tel;
        private System.Windows.Forms.Label label_permit;
        private System.Windows.Forms.Label label_social;
        private System.Windows.Forms.Label label_CPF;
    }
}