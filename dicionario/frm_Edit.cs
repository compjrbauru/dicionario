﻿using System;
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
        private CRUD crud = new CRUD();
        private Palavra p = new Palavra();
        private Rubrica rb = new Rubrica();
        private CategoriaGramatical ctg = new CategoriaGramatical();
        private Referencia refere = new Referencia();
        private List<object[]> resultados;
        private List<Palavra> resPalavra = new List<Palavra>();
        private int ipal = 0;
        private List<Rubrica> resRubrica = new List<Rubrica>();
        private List<CategoriaGramatical> resCtg = new List<CategoriaGramatical>();
        private List<Referencia> resRef = new List<Referencia>();

        private void EditForm_Load(object sender, EventArgs e)
        {
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
            ComboGenero.SelectedIndex = 2;
        }
        private void LimpaModel()
        {
            p.id = -1;
            p.lema = "";
            p.Id_catGram = 0;
            p.Genero = "N";
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
                resultados = crud.SelecionarTabela("categoriagram", CategoriaGramatical.ToListTabela(true), "Id=" + p.Id_catGram.ToString());
                resCtg = CategoriaGramatical.ConverteObject(resultados);
                ctg = resCtg.First();
                ComboCatGram.Text = ctg.descricao;
            }
            if (p.referencia_verbete > 0)
            {
                resultados = crud.SelecionarTabela("referencias", Referencia.ToListTabela(true), "Cod=" + p.referencia_verbete.ToString());
                resRef = Referencia.ConverteObject(resultados);
                refere = resRef.First();
                comboRef.Text = refere.descricao;
            }
            if (p.rubrica > 0)
            {
                resultados = crud.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), "Id=" + p.rubrica.ToString());
                resRubrica = Rubrica.ConverteObject(resultados);
                rb = resRubrica.First();
                ComboRubrica.Text = rb.descricao;
            }

            chkHeterogenerico.Checked = p.heterogenerico;
            chkHeterotonico.Checked = p.heterotonico;
            chkHeterossemantico.Checked = p.heterossemantico;
            numAcepcao.Value = p.acepcao; ///FIXME:bloquear a troca?
            textCultura.Text = p.nota_cultura;
            txtGramatica.Text = p.notas_gramatica;
            if (p.equivalente_pluriv != "{-1}")
            {
                txtEquiv.Visible = false;
                btnEquiv.Visible = true;
            }
            else
            {
                txtEquiv.Visible = true;
                btnEquiv.Visible = false;
            }
            switch (p.Genero) {
                case "M":
                    ComboGenero.SelectedIndex = 0;
                    break;
                case "N":
                    ComboGenero.SelectedIndex = 2;
                    break;
                case "F":
                    ComboGenero.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
        }
        private void AtivaNavegadores() {
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProx.Enabled = true;
            btnUltimo.Enabled = true;
        }
        private void DesativaNavegadores()
        {
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProx.Enabled = false;
            btnUltimo.Enabled = false;
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
                resultados  = crud.SelecionarTabela("palavra", Palavra.ToListTabela(true), "lema='" + searchBox.Text + "'");
                if (resultados.Count > 0)
                {
                    resPalavra = Palavra.ConverteObject(resultados);
                    p = resPalavra.First();
                    MostraDados();
                    if (resPalavra.Count == 1)
                    {
                        DesativaNavegadores();
                    }
                    else
                    {
                        AtivaNavegadores();
                        ipal = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum resultado adequado encontrado.");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (p.id <= 0 && txtpalavra.Text != "")
            {
                if (MessageBox.Show("Existem dados não salvos. Caso prossiga com a operação, todos os dados" + '\n' + "digitados serão perdidos. Continuar mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
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
            switch (ComboGenero.SelectedIndex)
            {
                case 0:
                    p.Genero = "M";
                    break;
                case 1:
                    p.Genero = "F";
                    break;
                default:
                    p.Genero = "N";
                    break;
            }
            /*if (txtpalavra.Text.Contains(' ')) { MessageBox.Show("Sem espaços no lema por enquanto", "aviso", MessageBoxButtons.OK);

            }
            
            else*/
            if (p.id <= 0)
            {
                crud.InsereLinha("palavra", Palavra.ToListTabela(), p.ToListValores());
                MessageBox.Show("Fazer lançamento na tabela de conjugações");
            }
            else
                crud.UpdateLine("palavra", Palavra.ToListTabela(), p.ToListValores(), "id=" + p.id.ToString());
            //Uma excessão pode ser lançda aqui quando os valores das chaves estrangerias forem <1, pois estão refernciando um valor que não existe. Como o int no c# não cabe um NULL, seria melhor não enviar o tal valor que evitamos o problema
            LimpaCampos();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar"+ '\n' + "Prosseguir?", "Confirmação",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    crud.ApagaLinha("palavra", "Id=" + p.id.ToString());
                    if (resPalavra.Count > 1)
                    {
                        resPalavra.Remove(p);
                        if (ipal > 0)
                            btnAnterior_Click(sender, e);
                        else
                            btnProx_Click(sender, e);
                    }
                    else {
                        LimpaModel();
                        LimpaCampos();
                    }                   
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
            pesquisa = ComboCatGram.Text;
            if (ComboCatGram.Items.Count > 0)
            {
                ComboCatGram.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resCtg = CategoriaGramatical.ConverteObject(crud.SelecionarTabela("categoriagram", CategoriaGramatical.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10"));
                List<string> d = new List<string>();
                foreach (CategoriaGramatical c in resCtg)
                {
                    d.Add(c.descricao);
                }
                foreach (string o in d)
                {
                    ComboCatGram.Items.Add(o);
                }
            }

            /*else
                resultados = crud.SelecionarTabela("categoriagram", CategoriaGramatical.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerCtg.Enabled = false; //prevenindo de floodar a combo
        }

        private void ComboCatGram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCatGram.Text != "") {
                if(ComboCatGram.Text.Length <= 3)
                    ctg = resCtg.Find(ctg => ctg.sigla == ComboCatGram.Text);
                else
                    ctg = resCtg.ElementAt(resCtg.FindIndex(ctg => ctg.descricao == ComboCatGram.Text));
                p.Id_catGram = ctg.id;
            }
                 //https://docs.microsoft.com/pt-br/dotnet/api/system.predicate-1?redirectedfrom=MSDN&view=netframework-4.7.2
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
                resultados = crud.SelecionarTabela("classegram", ClasseGramatical.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10");
                string[] siglas = new string[10];
                resultados[1].CopyTo(siglas, 0);
                while (siglas[i] != null && i < 10)
                {
                    ComboGenero.Items.Add(siglas[i++]);
                }
            }

            /*else
                resultados = crud.SelecionarTabela("classegram", ClasseGramatical.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerClg.Enabled = false; //prevenindo de floodar a combo
        }

        private void timerRub_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            pesquisa = ComboRubrica.Text;
            if (ComboRubrica.Items.Count > 0)
            {
                ComboRubrica.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resRubrica = Rubrica.ConverteObject(crud.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10"));
                List<string> d = new List<string>();
                foreach(Rubrica r in resRubrica)
                {
                    d.Add(r.descricao);
                }
                foreach(string s in d)
                {
                    ComboRubrica.Items.Add(s);
                }
            }

            /*else
                resultados = crud.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerRub.Enabled = false; //prevenindo de floodar a combo
        }

        private void ComboRubrica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboRubrica.Text != "")
            {
                rb = resRubrica.Find(rubrica => rubrica.descricao == ComboRubrica.Text);
                p.rubrica = rb.id;
            }
        }

        private void ComboRubrica_TextUpdate(object sender, EventArgs e)
        {
            if (timerRub.Enabled == true) { timerRub.Enabled = false; timerRub.Enabled = true; } else timerRub.Enabled = true;
        }

        private void timerRef_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            pesquisa = comboRef.Text;
            if (comboRef.Items.Count > 0)
            {
                comboRef.Items.Clear();
            }
            if (pesquisa.Length >= 5)
            {
                resRef = Referencia.ConverteObject(crud.SelecionarTabela("referencias", Referencia.ToListTabela(true), "Descricao LIKE '%" + pesquisa + "%'", "LIMIT 10"));
                List<string> d = new List<string>();
                foreach (Referencia re in resRef)
                {
                    d.Add(re.descricao);
                }
                foreach(string s in d)
                {
                    comboRef.Items.Add(s);
                }
            }

            /*else
                resultados = crud.SelecionarTabela("referencias", Referencia.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10");*/
            timerRef.Enabled = false; //prevenindo de floodar a combo
        }

        private void comboRef_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRef.Text != "")
            {
                refere = resRef.Find(r => r.descricao == comboRef.Text);
                p.referencia_verbete = refere.Cod;

            }
                //p.referencia_verbete = int.Parse(resultados[0].ElementAt(resultados[1].IndexOf(comboRef.Text)));
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

        private void btnConjuga_Click(object sender, EventArgs e)
        {
            if (p.id_conjuga > 0)
            {
                frm_conjuga fc = new frm_conjuga(p.id_conjuga);
                fc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Salve as alterações antes de acessar as conjugações", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (ipal > 0)
            {
                p = resPalavra.First();
                MostraDados();
                ipal = 0;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (ipal > 0)
            {
                p = resPalavra.ElementAt(--ipal);
                MostraDados();
            }
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (ipal < (resPalavra.Count - 1))
            {
                p = resPalavra.ElementAt(++ipal);
                MostraDados();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int mx = (resPalavra.Count - 1);
            if (ipal < mx)
            {
                p = resPalavra.Last();
                ipal = mx;
                MostraDados();
            }
        }
    }
}
