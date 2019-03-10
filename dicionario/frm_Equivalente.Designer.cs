namespace dicionario
{
    partial class frm_Equivalente
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
            this.btnVisao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.chkHtonico = new System.Windows.Forms.CheckBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkHgenerico = new System.Windows.Forms.CheckBox();
            this.chkHsemantico = new System.Windows.Forms.CheckBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.timerDestino = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnVisao
            // 
            this.btnVisao.Location = new System.Drawing.Point(719, 118);
            this.btnVisao.Name = "btnVisao";
            this.btnVisao.Size = new System.Drawing.Size(75, 46);
            this.btnVisao.TabIndex = 0;
            this.btnVisao.Text = "Mostrar estrangeiros";
            this.btnVisao.UseVisualStyleBackColor = true;
            this.btnVisao.Click += new System.EventHandler(this.btnVisao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verbete Origem";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(12, 89);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(304, 21);
            this.comboDestino.TabIndex = 3;
            this.comboDestino.SelectedIndexChanged += new System.EventHandler(this.comboDestino_SelectedIndexChanged);
            this.comboDestino.TextUpdate += new System.EventHandler(this.comboDestino_TextUpdate);
            // 
            // chkHtonico
            // 
            this.chkHtonico.AutoSize = true;
            this.chkHtonico.Location = new System.Drawing.Point(385, 89);
            this.chkHtonico.Name = "chkHtonico";
            this.chkHtonico.Size = new System.Drawing.Size(87, 17);
            this.chkHtonico.TabIndex = 4;
            this.chkHtonico.Text = "Heterotônico";
            this.chkHtonico.UseVisualStyleBackColor = true;
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Location = new System.Drawing.Point(12, 34);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(10, 13);
            this.lblOrigem.TabIndex = 5;
            this.lblOrigem.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verbete Destino";
            // 
            // chkHgenerico
            // 
            this.chkHgenerico.AutoSize = true;
            this.chkHgenerico.Location = new System.Drawing.Point(478, 89);
            this.chkHgenerico.Name = "chkHgenerico";
            this.chkHgenerico.Size = new System.Drawing.Size(99, 17);
            this.chkHgenerico.TabIndex = 8;
            this.chkHgenerico.Text = "Heterogenérico";
            this.chkHgenerico.UseVisualStyleBackColor = true;
            // 
            // chkHsemantico
            // 
            this.chkHsemantico.AutoSize = true;
            this.chkHsemantico.Location = new System.Drawing.Point(586, 89);
            this.chkHsemantico.Name = "chkHsemantico";
            this.chkHsemantico.Size = new System.Drawing.Size(111, 17);
            this.chkHsemantico.TabIndex = 9;
            this.chkHsemantico.Text = "Heterossemântico";
            this.chkHsemantico.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(822, 40);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(822, 69);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 11;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Location = new System.Drawing.Point(822, 98);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(75, 23);
            this.btnApaga.TabIndex = 12;
            this.btnApaga.Text = "Apagar";
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(719, 2);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(75, 23);
            this.btnPrimeiro.TabIndex = 13;
            this.btnPrimeiro.Text = "|<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(719, 89);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 16;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(719, 60);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 15;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(719, 31);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // timerDestino
            // 
            this.timerDestino.Interval = 700;
            this.timerDestino.Tick += new System.EventHandler(this.timerDestino_Tick);
            // 
            // frm_Equivalente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 176);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnApaga);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.chkHsemantico);
            this.Controls.Add(this.chkHgenerico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.chkHtonico);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisao);
            this.MaximizeBox = false;
            this.Name = "frm_Equivalente";
            this.Text = "Entradas equivalentes";
            this.Load += new System.EventHandler(this.frm_Equivalente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.CheckBox chkHtonico;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkHgenerico;
        private System.Windows.Forms.CheckBox chkHsemantico;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApaga;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Timer timerDestino;
    }
}