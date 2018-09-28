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
        /*frm_Edit objEditForm;
        frm_configuracao configForm;*/
        List<Palavra> resultadosPalavra;
        CRUD cRUD = new CRUD();
        public frm_busca()
        {
            //O Construtor esconde o ResultsBox, que só é mostrado depois de uma
            //busca.
            InitializeComponent();
            this.searchResultsListBox.Hide();
            this.extraComboBox1.Hide();
            this.extraComboBox2.Hide();

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
            List<object[]> lista = new List<object[]>();
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
            lista = cRUD.SelecionarTabela("palavra", Palavra.ToListTabela(true),filtro , "ORDER BY lema ASC");
            searchResultsListBox.Items.Clear();
            if (lista.Count > 0)
            {
                try
                {
                    resultadosPalavra.Clear();
                }
                catch (NullReferenceException) {
                    resultadosPalavra = new List<Palavra>();
                }
                /*int lim = lista.Count;
                Palavra pt = new Palavra();
                object[] po = new object[Palavra.ToListTabela(true).Count];
                for (int i = 0; i < lim; i++)
                {
                    po = lista.ElementAt(i);
                    pt = (Palavra)po;
                    searchResultsListBox.Items.Add(pt.lema);
                    resultadosPalavra.Add(pt);
                }*/
                resultadosPalavra = Palavra.ConverteObject(lista);
                foreach (Palavra item in resultadosPalavra)
                {
                    searchResultsListBox.Items.Add(item.lema);
                }
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
        private void searchResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            Palavra resultado  = resultadosPalavra.ElementAt(searchResultsListBox.SelectedIndex);
            frm_visualizaverbete _Visualizaverbete = new frm_visualizaverbete(resultado);
            _Visualizaverbete.ShowDialog();
        }
    }
}
