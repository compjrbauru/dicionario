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
            this.SuspendLayout();
            // 
            // txtusr
            // 
            this.txtusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtusr.Location = new System.Drawing.Point(62, 73);
            this.txtusr.Name = "txtusr";
            this.txtusr.Size = new System.Drawing.Size(160, 26);
            this.txtusr.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpass.Location = new System.Drawing.Point(62, 105);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(160, 26);
            this.txtpass.TabIndex = 1;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContato.Location = new System.Drawing.Point(62, 201);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(160, 26);
            this.txtContato.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(62, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(62, 169);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 26);
            this.txtNome.TabIndex = 3;
            // 
            // txtRSoc
            // 
            this.txtRSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRSoc.Location = new System.Drawing.Point(62, 233);
            this.txtRSoc.Name = "txtRSoc";
            this.txtRSoc.Size = new System.Drawing.Size(160, 26);
            this.txtRSoc.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCpf.Location = new System.Drawing.Point(62, 265);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(160, 26);
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
            this.comboPermissao.Location = new System.Drawing.Point(363, 71);
            this.comboPermissao.Name = "comboPermissao";
            this.comboPermissao.Size = new System.Drawing.Size(149, 28);
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
            this.btnincluir.Location = new System.Drawing.Point(471, 289);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(102, 33);
            this.btnincluir.TabIndex = 8;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // frm_controledeusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
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
    }
}