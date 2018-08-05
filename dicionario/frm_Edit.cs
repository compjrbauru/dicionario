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
        private Rubrica rb = new Rubrica();
        private CategoriaGramatical ctg = new CategoriaGramatical();
        //private ClasseGramatical clg = new ClasseGramatical();
        List<string>[] resultados;
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
            chkHeterogenerico.Checked = false;
            chkHeterotonico.Checked = false;
            chkHeterossemantico.Checked = false;
            txtpalavra.Text = "";
            comboRef.SelectedIndex = -1;
            comboRef.Text = "";
            ComboCatGram.SelectedIndex = -1;
            ComboCatGram.Text = "";
            ComboGenero.SelectedIndex = -1;
            ComboGenero.Text = "";
            ComboIdioma.SelectedIndex = -1;
            ComboIdioma.Text = "";
            ComboRubrica.SelectedIndex = -1;
            ComboRubrica.Text = "";
            txtExemploT.Text = "";
            txtExemplo.Text = "";
            textCultura.Text = "";
        }
        private void LimpaModel()
        {
            p.id = -1;
            p.lema = "";
            p.Id_catGram = 0;
            p.Genero = "";
            p.rubrica = 0;
            p.referencia_verbete = 0;
            p.heterogenerico = false;
            p.heterossemantico = false;
            p.heterotonico = false;
        }
        private void MostraDados()
        {
            txtpalavra.Text = p.lema;
            if (p.idioma == "PT")
                ComboIdioma.SelectedIndex = 0;
            else
            {
                if (p.idioma == "ES")
                    ComboIdioma.SelectedIndex = 2;
                else
                {
                    ComboIdioma.SelectedIndex = 1;
                }
            }
            if (p.Id_catGram > 0)
            {
                resultados = conexao.Select("categoriagram", CategoriaGramatical.ToListTabela(true), "Id=" + p.Id_catGram.ToString());
                ComboCatGram.Text = resultados[1].ElementAt(0);
            }
            if (p.referencia_verbete > 0)
            {
                resultados = conexao.Select("referencias", Referencia.ToListTabela(true), "Id=" + p.referencia_verbete.ToString());
                comboRef.Text = resultados[1].ElementAt(0);
            }
            if (p.rubrica > 0)
            {
                resultados = conexao.Select("rubrica", Rubrica.ToListTabela(true), "Id=" + p.rubrica.ToString());
                ComboRubrica.Text = resultados[1].ElementAt(0);
            }

            chkHeterogenerico.Checked = p.heterogenerico;
            chkHeterotonico.Checked = p.heterotonico;
            chkHeterossemantico.Checked = p.heterossemantico;
            numAcepcao.Value = p.acepcao; //bloquear a troca?
            textCultura.Text = p.nota_cultura;
            txtGramatica.Text = p.notas_gramatica;
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
                string filtroquery;
                int temp;
                switch (filterComboBox.SelectedIndex)
                {
                    case 1:
                        filtroquery = "Cod";
                        break;
                    default:
                        filtroquery = "lema";
                        break;
                }
                switch (ComboFiltroPrecisao.SelectedIndex)
                {
                    case 1:
                        filtroquery += " LIKE '" + searchBox.Text + "%'";
                        break;
                    default:
                        filtroquery += "=";
                        if (int.TryParse(searchBox.Text, out temp))
                            filtroquery += searchBox.Text;
                        else
                            filtroquery += "'" + searchBox.Text + "'";
                        break;
                }
                switch (comboFiltroIdiomas.SelectedIndex)
                {
                    case 1:
                        filtroquery += "AND Idioma='PT'";
                        break;
                    case 2:
                        filtroquery += "AND Idioma='EN'";
                        break;
                    case 3:
                        filtroquery += "AND Idioma='ES'";
                        break;
                    default:
                        break;
                }
                resultados  = conexao.Select("palavra", Palavra.ToListTabela(), "lema='" + searchBox.Text + "'");
                ///FIXME: Temos isso dentro da classe palavra
                if (resultados[0].Count == 1)
                {
                    p.id = int.Parse(resultados[0].ElementAt(0));
                    p.lema = resultados[1].ElementAt(0);
                    p.Id_catGram = int.Parse(resultados[2].ElementAt(0));
                    p.Genero = resultados[3].ElementAt(0);
                    p.idioma = resultados[4].ElementAt(0);
                    p.rubrica = int.Parse(resultados[5].ElementAt(0));
                    p.heterogenerico = Boolean.Parse(resultados[6].ElementAt(0));
                    p.heterotonico = Boolean.Parse(resultados[7].ElementAt(0));
                    p.equivalente = int.Parse(resultados[8].ElementAt(0));
                    p.referencia_verbete = int.Parse(resultados[9].ElementAt(0));
                    p.referencia_exemplo = resultados[10].ElementAt(0);
                    p.notas_gramatica = resultados[11].ElementAt(0);
                    p.nota_cultura = resultados[12].ElementAt(0);
                    p.acepcao = int.Parse(resultados[13].ElementAt(0));
                    p.heterossemantico = Boolean.Parse(resultados[14].ElementAt(0));
                    p.ref_ex_tr = resultados[15].ElementAt(0);
                    p.Infinitivo = int.Parse(resultados[16].ElementAt(0));

                    MostraDados();
                }
                else { }
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
//NOTE: Se houver problemas ao salvar, foi criado um INDEX na tabela com o nome Lema_UNIQUE
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
            p.acepcao = (int)numAcepcao.Value;
            p.heterogenerico = chkHeterogenerico.Checked;
            p.heterotonico = chkHeterotonico.Checked;
            p.notas_gramatica = txtGramatica.Text;
            p.nota_cultura = textCultura.Text;
            p.heterossemantico = chkHeterossemantico.Checked;
            p.referencia_exemplo = txtExemplo.Text;
            p.ref_ex_tr = txtExemploT.Text;
            if (txtpalavra.Text.Contains(' ')) { MessageBox.Show("Sem espaços no lema por enquanto", "aviso", MessageBoxButtons.OK); }
            
            else
                conexao.InsereLinha("palavra", Palavra.ToListTabela(), p.ToListValores());
            //Uma excessão pode ser lançda aqui quando os valores das chaves estrangerias forem <1, pois estão refernciando um valor que não existe. Como o int no c# não cabe um NULL, seria melhor não enviar o tal valor que evitamos o problema
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

        private void ComboCatGram_TextUpdate(object sender, EventArgs e)
        {
            if (timerCtg.Enabled == true) { timerCtg.Enabled = false; timerCtg.Enabled = true; } else timerCtg.Enabled = true;
            // pesquisar itens, se o tmanho = 3, bscar sigla. Caso maior, pesquisar descrição
            //preencher o combobox.itens.add com cada item
            //ver como funciona o autocomplete
            //colocar o selected index com o valor do ID do item selecionado          
        }

        private void timerCtg_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            int i = 0;
            pesquisa = ComboCatGram.Text;
            if (ComboCatGram.Items.Count > 0)
            {
                ComboCatGram.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resultados = conexao.Select("categoriagram", CategoriaGramatical.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10");
                string[] siglas = new string[10];
                resultados[1].CopyTo(siglas, 0);
                while (siglas[i] != null && i<10)
                {
                    ComboCatGram.Items.Add(siglas[i++]);
                }
            }

            /*else
                resultados = conexao.Select("categoriagram", CategoriaGramatical.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerCtg.Enabled = false; //prevenindo de floodar a combo
        }

        private void ComboCatGram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCatGram.Text != "")
                p.Id_catGram = int.Parse(resultados[0].ElementAt(resultados[1].IndexOf(ComboCatGram.Text)));
        }

        private void ComboClasseGram_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (ComboClasseGram.Text != "")
                p.Id_classeGram = int.Parse(resultados[0].ElementAt(resultados[1].IndexOf(ComboClasseGram.Text)));*/
        }

        private void ComboClasseGram_TextUpdate(object sender, EventArgs e)
        {
            /*if (timerClg.Enabled == true) { timerClg.Enabled = false; timerClg.Enabled = true; } else timerClg.Enabled = true;*/
        }

        private void timerClg_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            int i = 0;
            pesquisa = ComboGenero.Text;
            if (ComboGenero.Items.Count > 0)
            {
                ComboGenero.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resultados = conexao.Select("classegram", ClasseGramatical.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10");
                string[] siglas = new string[10];
                resultados[1].CopyTo(siglas, 0);
                while (siglas[i] != null && i < 10)
                {
                    ComboGenero.Items.Add(siglas[i++]);
                }
            }

            /*else
                resultados = conexao.Select("classegram", ClasseGramatical.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerClg.Enabled = false; //prevenindo de floodar a combo
        }

        private void timerRub_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            int i = 0;
            pesquisa = ComboRubrica.Text;
            if (ComboRubrica.Items.Count > 0)
            {
                ComboRubrica.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resultados = conexao.Select("rubrica", Rubrica.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10");
                string[] siglas = new string[10];
                resultados[1].CopyTo(siglas, 0);
                while (siglas[i] != null && i < 10)
                {
                    ComboRubrica.Items.Add(siglas[i++]);
                }
            }

            /*else
                resultados = conexao.Select("rubrica", Rubrica.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerRub.Enabled = false; //prevenindo de floodar a combo
        }

        private void ComboRubrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboRubrica.Text != "")
                p.rubrica = int.Parse(resultados[0].ElementAt(resultados[1].IndexOf(ComboRubrica.Text)));
        }

        private void ComboRubrica_TextUpdate(object sender, EventArgs e)
        {
            if (timerRub.Enabled == true) { timerRub.Enabled = false; timerRub.Enabled = true; } else timerRub.Enabled = true;
        }

        private void timerRef_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            int i = 0;
            pesquisa = comboRef.Text;
            if (comboRef.Items.Count > 0)
            {
                comboRef.Items.Clear();
            }
            if (pesquisa.Length > 5)
            {
                resultados = conexao.Select("referencias", Referencia.ToListTabela(true), "Descricao LIKE '" + pesquisa + "%'", "LIMIT 10");
                string[] desc = new string[10];
                resultados[1].CopyTo(desc, 0);
                while (desc[i] != null && i < 10)
                {
                    comboRef.Items.Add(desc[i++]);
                }
            }

            /*else
                resultados = conexao.Select("referencias", Referencia.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerRef.Enabled = false; //prevenindo de floodar a combo
        }

        private void comboRef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRef.Text != "")
                p.referencia_verbete = int.Parse(resultados[0].ElementAt(resultados[1].IndexOf(comboRef.Text)));
        }

        private void comboRef_TextUpdate(object sender, EventArgs e)
        {
            if (timerRef.Enabled == true) { timerRef.Enabled = false; timerRef.Enabled = true; } else timerRef.Enabled = true;
        }

        private void txtpalavra_Leave(object sender, EventArgs e)
        {
            if (txtpalavra.Text.Contains(' ') && txtpalavra.Text.Last()!= ' ')
            {
                btnEquiv.Visible = true;
                txtEquiv.Visible = false;
            }
            else
            {
                btnEquiv.Visible = false;
                txtEquiv.Visible = true;
            }
        }

        private void btnEquiv_Click(object sender, EventArgs e)
        {
            string[] lemas = txtpalavra.Text.Split(' ');
            List<int> saidas = new List<int>();
            diag_equivalente diag;
            for (int i = 0; i < lemas.Count(); i++)
            {
                diag = new diag_equivalente(lemas[i]);
                diag.ShowDialog();
                if (diag.DialogResult == DialogResult.OK)
                    saidas.Add(diag.selecionado);
                else
                    saidas.Add(-1);
                diag.Dispose();
            }
            p.EditRelacoesPluri(saidas);
        }
    }
}
