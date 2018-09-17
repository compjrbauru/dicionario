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
    public partial class frm_busca : Form
    {
        frm_Edit objEditForm;
        frm_configuracao configForm;
        List<Palavra> palavra;
        List<string>[] resultadosPalavra;
        ConectaBanco conexao;

        public frm_busca()
        {
            //O Construtor esconde o ResultsBox, que só é mostrado depois de uma
            //busca.
            InitializeComponent();
            this.searchResultsListBox.Hide();
            this.extraComboBox1.Hide();
            this.extraComboBox2.Hide();
            conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        }

        private void contactButton_Click(object sender, EventArgs e)
        {
            //Por hora, cria uma nova instância do mesmo form.
            //Trocar o HomeForm para os Forms corretos.
            frm_contato contato = new frm_contato();
            contato.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
            {
                MessageBox.Show("A caixa de busca não pode estar vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string filtro = "";
            switch (filterComboBox.SelectedIndex)
            {
                case 1:
                    filtro += "lema LIKE'" + searchBox.Text + "'";
                    break;
                case 2:
                    //anagrama
                    break;
                case 3:
                    //filtro += "definicao LIKE '" + searchBox.Text + "'";
                    break;
                case 4:
                    //exemplo
                    break;
                case 5:
                    //Heterogenérico
                    break;
                case 6:
                    //Heterotônico
                    break;
                default:
                    filtro += "lema='" + searchBox.Text + "'";
                    break;
            }
            resultadosPalavra = conexao.Select("palavra", Palavra.ToListTabela(true),filtro , "ORDER BY lema ASC");
            searchResultsListBox.Items.Clear();
            if (resultadosPalavra[0].Count > 0)
            {
                foreach (string item in resultadosPalavra[1])
                    this.searchResultsListBox.Items.Add(item);
                OrganizaResultados();
                searchResultsListBox.Enabled = true;
            }
            else
            {
                searchResultsListBox.Items.Add("Nenhum resultado encontrado. Verifique seus critérios de pesquisa!");
                searchResultsListBox.Enabled = false;
            }
            this.searchResultsListBox.Show();
        }

        private void searchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void editModeButton_Click(object sender, EventArgs e)
        {
            Login l = new Login(new frm_Edit());
            l.ShowDialog();
            l.Dispose();

            /*this.objEditForm = new frm_Edit();
            this.objEditForm.Show(this);
            this.objEditForm.BringToFront();
            this.Hide();*/
        }

        private void extraFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (extraFilterCheckBox.Checked)
            {
                this.extraComboBox1.Show();
                this.extraComboBox2.Show();
            }
            else if (!extraFilterCheckBox.Checked)
            {
                this.extraComboBox1.Hide();
                this.extraComboBox2.Hide();
            }
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            Login l = new Login(new frm_controledeusuario(),0);
            l.ShowDialog();
            l.Dispose();

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
        private void OrganizaResultados()
            ///TODO:Modelo de tradução vetor-tipo MVC
        {
            int t = resultadosPalavra[0].Count;
            int dummy;
            try
            {
                if (palavra.Count > 0)
                    palavra.Clear();
            }
            catch (NullReferenceException) { }
            Palavra temp = new Palavra();
            for (int e = 0; e < t; e++)
            {
                temp.id = int.Parse(resultadosPalavra[0].ElementAt(e));
                temp.lema = resultadosPalavra[1].ElementAt(e);
                temp.Id_catGram = int.Parse(resultadosPalavra[2].ElementAt(e));
                
                temp.idioma = resultadosPalavra[3].ElementAt(e);
                temp.rubrica = int.Parse(resultadosPalavra[4].ElementAt(e));
                temp.heterogenerico = Boolean.Parse(resultadosPalavra[5].ElementAt(e));
                temp.heterotonico = Boolean.Parse(resultadosPalavra[6].ElementAt(e));
                int.TryParse(resultadosPalavra[7].ElementAt(e), out dummy);
                temp.equivalente = dummy;
                int.TryParse(resultadosPalavra[8].ElementAt(e), out dummy);
                temp.referencia_verbete = dummy;
                temp.referencia_exemplo = resultadosPalavra[9].ElementAt(e);
                temp.notas_gramatica = resultadosPalavra[10].ElementAt(e);
                temp.nota_cultura = resultadosPalavra[11].ElementAt(e);
                temp.acepcao = int.Parse(resultadosPalavra[12].ElementAt(e));
                temp.heterossemantico = Boolean.Parse(resultadosPalavra[13].ElementAt(e));
                temp.ref_ex_tr = resultadosPalavra[14].ElementAt(e);
                int.TryParse(resultadosPalavra[15].ElementAt(e),out dummy);
                temp.Infinitivo = dummy;
                temp.Genero = resultadosPalavra[16].ElementAt(e);
            }
            try
            {
                palavra.Add(temp);
            }
            catch (NullReferenceException) { palavra = new List<Palavra>(); palavra.Add(temp); }
        }
        private void searchResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            Palavra resultado  = palavra.ElementAt(searchResultsListBox.SelectedIndex);
            frm_visualizaverbete _Visualizaverbete = new frm_visualizaverbete(resultado);
            _Visualizaverbete.ShowDialog();
        }
    }
}
