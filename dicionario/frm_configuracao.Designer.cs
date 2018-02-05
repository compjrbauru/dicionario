namespace dicionario
{
    partial class frm_configuracao
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
            this.ConnNameTextBox = new System.Windows.Forms.TextBox();
            this.ConnNameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.HostnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portNameTextBox = new System.Windows.Forms.TextBox();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.pswdLabel = new System.Windows.Forms.Label();
            this.usrNameLabel = new System.Windows.Forms.Label();
            this.usrNameTextBox = new System.Windows.Forms.TextBox();
            this.confOkButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.editModeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.contactButton = new System.Windows.Forms.Button();
            this.ConfigButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnNameTextBox
            // 
            this.ConnNameTextBox.Location = new System.Drawing.Point(142, 113);
            this.ConnNameTextBox.Name = "ConnNameTextBox";
            this.ConnNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConnNameTextBox.TabIndex = 0;
            // 
            // ConnNameLabel
            // 
            this.ConnNameLabel.AutoSize = true;
            this.ConnNameLabel.Location = new System.Drawing.Point(41, 113);
            this.ConnNameLabel.Name = "ConnNameLabel";
            this.ConnNameLabel.Size = new System.Drawing.Size(95, 13);
            this.ConnNameLabel.TabIndex = 1;
            this.ConnNameLabel.Text = "Nome da Conexão";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // HostnameLabel
            // 
            this.HostnameLabel.AutoSize = true;
            this.HostnameLabel.Location = new System.Drawing.Point(41, 189);
            this.HostnameLabel.Name = "HostnameLabel";
            this.HostnameLabel.Size = new System.Drawing.Size(55, 13);
            this.HostnameLabel.TabIndex = 3;
            this.HostnameLabel.Text = "Hostname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port";
            // 
            // portNameTextBox
            // 
            this.portNameTextBox.Location = new System.Drawing.Point(292, 186);
            this.portNameTextBox.Name = "portNameTextBox";
            this.portNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.portNameTextBox.TabIndex = 5;
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.Location = new System.Drawing.Point(292, 222);
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.Size = new System.Drawing.Size(100, 20);
            this.pswdTextBox.TabIndex = 9;
            // 
            // pswdLabel
            // 
            this.pswdLabel.AutoSize = true;
            this.pswdLabel.Location = new System.Drawing.Point(248, 225);
            this.pswdLabel.Name = "pswdLabel";
            this.pswdLabel.Size = new System.Drawing.Size(38, 13);
            this.pswdLabel.TabIndex = 8;
            this.pswdLabel.Text = "Senha";
            // 
            // usrNameLabel
            // 
            this.usrNameLabel.AutoSize = true;
            this.usrNameLabel.Location = new System.Drawing.Point(41, 225);
            this.usrNameLabel.Name = "usrNameLabel";
            this.usrNameLabel.Size = new System.Drawing.Size(55, 13);
            this.usrNameLabel.TabIndex = 7;
            this.usrNameLabel.Text = "Username";
            // 
            // usrNameTextBox
            // 
            this.usrNameTextBox.Location = new System.Drawing.Point(142, 222);
            this.usrNameTextBox.Name = "usrNameTextBox";
            this.usrNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usrNameTextBox.TabIndex = 6;
            // 
            // confOkButton
            // 
            this.confOkButton.Location = new System.Drawing.Point(44, 265);
            this.confOkButton.Name = "confOkButton";
            this.confOkButton.Size = new System.Drawing.Size(75, 23);
            this.confOkButton.TabIndex = 10;
            this.confOkButton.Text = "Ok";
            this.confOkButton.UseVisualStyleBackColor = true;
            this.confOkButton.Click += new System.EventHandler(this.confOkButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(45, 38);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 30);
            this.homeButton.TabIndex = 14;
            this.homeButton.Text = "Busca";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // editModeButton
            // 
            this.editModeButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editModeButton.Location = new System.Drawing.Point(510, 38);
            this.editModeButton.Name = "editModeButton";
            this.editModeButton.Size = new System.Drawing.Size(75, 30);
            this.editModeButton.TabIndex = 13;
            this.editModeButton.Text = "Edição";
            this.editModeButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(208, 38);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 30);
            this.helpButton.TabIndex = 12;
            this.helpButton.Text = "Ajuda";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // contactButton
            // 
            this.contactButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactButton.Location = new System.Drawing.Point(126, 38);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(75, 30);
            this.contactButton.TabIndex = 11;
            this.contactButton.Text = "Contato";
            this.contactButton.UseVisualStyleBackColor = true;
            // 
            // ConfigButton
            // 
            this.ConfigButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigButton.Location = new System.Drawing.Point(289, 38);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(100, 30);
            this.ConfigButton.TabIndex = 21;
            this.ConfigButton.Text = "Configuração";
            this.ConfigButton.UseVisualStyleBackColor = true;
            // 
            // frm_configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.ConfigButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.editModeButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.contactButton);
            this.Controls.Add(this.confOkButton);
            this.Controls.Add(this.pswdTextBox);
            this.Controls.Add(this.pswdLabel);
            this.Controls.Add(this.usrNameLabel);
            this.Controls.Add(this.usrNameTextBox);
            this.Controls.Add(this.portNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HostnameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ConnNameLabel);
            this.Controls.Add(this.ConnNameTextBox);
            this.Name = "frm_configuracao";
            this.Text = "frm_configuracao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnNameTextBox;
        private System.Windows.Forms.Label ConnNameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label HostnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portNameTextBox;
        private System.Windows.Forms.TextBox pswdTextBox;
        private System.Windows.Forms.Label pswdLabel;
        private System.Windows.Forms.Label usrNameLabel;
        private System.Windows.Forms.TextBox usrNameTextBox;
        private System.Windows.Forms.Button confOkButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button editModeButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button ConfigButton;
    }
}