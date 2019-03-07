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
            this.equivalenteGrid = new System.Windows.Forms.DataGridView();
            this.Origem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heterogenerico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.heterotonico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.heterossemantico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.equivalenteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // equivalenteGrid
            // 
            this.equivalenteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equivalenteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origem,
            this.Destino,
            this.heterogenerico,
            this.heterotonico,
            this.heterossemantico});
            this.equivalenteGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equivalenteGrid.Location = new System.Drawing.Point(0, 0);
            this.equivalenteGrid.Name = "equivalenteGrid";
            this.equivalenteGrid.Size = new System.Drawing.Size(905, 531);
            this.equivalenteGrid.TabIndex = 0;
            // 
            // Origem
            // 
            this.Origem.HeaderText = "Origem";
            this.Origem.Name = "Origem";
            this.Origem.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            // 
            // heterogenerico
            // 
            this.heterogenerico.HeaderText = "Heterogenérico";
            this.heterogenerico.Name = "heterogenerico";
            // 
            // heterotonico
            // 
            this.heterotonico.HeaderText = "Heterotônico";
            this.heterotonico.Name = "heterotonico";
            // 
            // heterossemantico
            // 
            this.heterossemantico.FalseValue = "0";
            this.heterossemantico.HeaderText = "Heterossemântico";
            this.heterossemantico.Name = "heterossemantico";
            this.heterossemantico.TrueValue = "1";
            // 
            // frm_Equivalente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 531);
            this.Controls.Add(this.equivalenteGrid);
            this.Name = "frm_Equivalente";
            this.Text = "Entradas equivalentes";
            this.Load += new System.EventHandler(this.frm_Equivalente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equivalenteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView equivalenteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewCheckBoxColumn heterogenerico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn heterotonico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn heterossemantico;
    }
}