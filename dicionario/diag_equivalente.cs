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
        ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        CRUD c = new CRUD();
        List<CategoriaGramatical> resultados;
        public int selecionado;
        //talvez seja melhor salvar os resultados antes e depois, como entrada, enviar um int indicando qual palavra é obsevada
        public diag_equivalente(string lema)
        {
            InitializeComponent();
            label2.Text = lema;
        }

        private void BuscaTimer_Tick(object sender, EventArgs e)
        {
            
            string pesquisa;
            int i = 0;
            pesquisa = comboBusca.Text;
            if (comboBusca.Items.Count > 0)
            {
                comboBusca.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resultados = CategoriaGramatical.ConverteObject(c.SelecionarTabela("categoriagram", CategoriaGramatical.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10")); //TODO: Trocar a tabela para palavra e atualizar  ofiltro de pesquisa
                /*string[] siglas = new string[10];
                resultados[1].CopyTo(siglas, 0);
                while (siglas[i] != null && i < 10)
                {
                    comboBusca.Items.Add(siglas[i] + " Ac " + resultados[0].ElementAt(i++) ); //colocar a coluna acepcao
                }*/
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
                //selecionado = int.Parse(resultados[0].ElementAt(resultados[1].IndexOf(comboBusca.Text.Remove(comboBusca.Text.LastIndexOf(' ') - 3))));
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
