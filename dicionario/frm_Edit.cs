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
    public partial class frm_Edit : Form
    {
        public frm_Edit()
        {
            InitializeComponent();
        }
        private ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        private Palavra p = new Palavra();
        private void homeButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Faz o form pai aparecer
            Owner.Show();
        }
        private void LimpaCampos()
        {
            txtAcepcao.Text = "";
            txtEquiv.Text = "";
            txtGramatica.Text = "";
            txtHeterog.Text = "";
            txtpalavra.Text = "";
            txtRef.Text = "";
            ComboCatGram.SelectedIndex = -1;
            ComboCatGram.Text = "";
            ComboClasseGram.SelectedIndex = -1;
            ComboClasseGram.Text = "";
            ComboIdioma.SelectedIndex = -1;
            ComboIdioma.Text = "";
            ComboRubrica.SelectedIndex = -1;
            ComboRubrica.Text = "";
        }
        private void LimpaModel()
        {
            p.id = -1;
            p.lema = "";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                List<string>[] resultados  = conexao.Select("Palavra", Palavra.ToListTabela(), "palavra='" + searchBox.Text + "'");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (p.id == 0 && txtpalavra.Text != "")
            {
                if(MessageBox.Show("Existem dados não salvos. Caso prossiga com a operação, todos os dados" + '\n' + "digitados serão perdidos. Continuar mesmo assim?", "Atenção", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(txtpalavra.Text == String.Empty)
            {
                MessageBox.Show("Palavra não pode ser vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (txtpalavra.Text.Contains('{') || txtpalavra.Text.Contains('}')) { }
            string lng;
            p.lema = txtpalavra.Text;

            switch (ComboIdioma.SelectedIndex)
            {
                case 0:
                    lng = "PT";
                    break;
                case 2:
                    lng = "EN";
                    break;
                case 1:
                    lng = "ES";
                    break;
                default:
                    lng = "";
                    break;
            }
            p.idioma = lng;
            p.acepcao = txtAcepcao.Text;
            p.heterogenerico = txtHeterog.Text;
            p.heterotonico = txtHeterot.Text;
            p.notas_gramatica = txtGramatica.Text;
            if (txtpalavra.Text.Contains(' ')) { }
            
            else
                conexao.InsereLinha("palavra", Palavra.ToListTabela(), p.ToListValores());
            LimpaCampos();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar"+ '\n' + "Prosseguir?", "Confirmação",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    conexao.ApagaLinha("palavra", "Id=" + p.id.ToString());
                    LimpaModel();
                    LimpaCampos();
                }
            }
            
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportaCsv ICsv = new frmImportaCsv();
            ICsv.Show();
        }

        private void rubricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rubrica _Rubrica = new frm_rubrica();
            _Rubrica.ShowDialog();
        }

        private void classeGramaticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CssGr clGram = new frm_CssGr();
            clGram.ShowDialog();
        }

        private void categoriaGramaticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categoriaGramatical ctGram = new frm_categoriaGramatical();
            ctGram.ShowDialog();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_contato cont = new frm_contato();
            cont.ShowDialog();
        }

        private void referênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_referencia rf = new frm_referencia();
            rf.ShowDialog();
        }
    }
}
