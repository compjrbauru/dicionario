using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dicionario.Model;

namespace dicionario
{
    public partial class diag_equivalente : Form
    {
        CRUD c = new CRUD();
        List<Palavra> resultados;
        public int selecionado;
        ///NOTE: talvez seja melhor salvar os resultados antes e depois, como entrada, enviar um int indicando qual palavra é obsevada
        public diag_equivalente(string lema)
        {
            InitializeComponent();
            label2.Text = lema;
        }

        private void BuscaTimer_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            pesquisa = comboBusca.Text;
            if (comboBusca.Items.Count > 0)
            {
                comboBusca.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resultados = Palavra.ConverteObject(c.SelecionarTabela("palavra", Palavra.ToListTabela(true), "lema LIKE '" + pesquisa + "%'", "LIMIT 10"));
                foreach(Palavra palavra in resultados)
                {
                    pesquisa = palavra.lema + " Acepção " + palavra.acepcao.ToString();
                    comboBusca.Items.Add(pesquisa);
                }
            }
            BuscaTimer.Enabled = false;
        }

        private void comboBusca_TextUpdate(object sender, EventArgs e)
        {
            if (BuscaTimer.Enabled == true) { BuscaTimer.Enabled = false; BuscaTimer.Enabled = true; } else BuscaTimer.Enabled = true;
        }

        private void comboBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBusca.Text != "")
            {
                selecionado = resultados.ElementAt(comboBusca.SelectedIndex).id;
                button2.Enabled = true;
            }
            else
                button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
