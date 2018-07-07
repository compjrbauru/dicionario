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
        Palavra Palavra;
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
                    //filtro += "acepcao LIKE '" + searchBox.Text + "'";
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
            foreach (string item in resultadosPalavra[1])
                this.searchResultsListBox.Items.Add(item);
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
            this.objEditForm = new frm_Edit();
            this.objEditForm.Show(this);
            this.objEditForm.BringToFront();
            this.Hide();
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
            this.configForm = new frm_configuracao();
            this.configForm.Show(this);
            this.configForm.BringToFront();
            this.Hide();

        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        private void searchResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            /*Palavra resultado;
            for (int i = 0; i < 16; i++)
                resultadosPalavra.ElementAt(searchResultsListBox.SelectedIndex);
            frm_visualizaverbete _Visualizaverbete = new frm_visualizaverbete(resultado);*/
        }
    }
}
