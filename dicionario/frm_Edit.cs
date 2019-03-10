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
using dicionario.Helpers;

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
        private ClasseGramatical clg = new ClasseGramatical();
        private Referencia refere = new Referencia();
        private List<object[]> resultados;
        private List<Palavra> resPalavra = new List<Palavra>();
        private int ipal = 0;
        private List<Rubrica> resRubrica = new List<Rubrica>();
        private List<ClasseGramatical> resClg = new List<ClasseGramatical>();
        private List<Referencia> resRef = new List<Referencia>();
        private List<CategoriaGramatical> resCtg;

        private void EditForm_Load(object sender, EventArgs e)
        {
        }
        private void LimpaCampos()
        {
            txtAcepcao.Text = "";
            txtGramatica.Text = "";
            txtpalavra.Text = "";
            comboRef.SelectedIndex = -1;
            comboRef.Text = "";
            ComboClasseGram.SelectedIndex = -1;
            ComboClasseGram.Text = "";
            ComboGenero.SelectedIndex = -1;
            ComboGenero.Text = "";
            ComboIdioma.SelectedIndex = -1;
            ComboIdioma.Text = "";
            ComboRubrica.SelectedIndex = -1;
            ComboRubrica.Text = "";
            txtExemploT.Text = "";
            txtExemplo.Text = "";
            textCultura.Text = "";

            btnEquiv.Enabled = false;
            btnConjuga.Enabled = false;
        }
        private void LimpaModel()
        {
            p.id = -1;
            p.lema = "";
            //p.Id_catGram = 0;
            p.Id_classeGram = 0;
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
            if (p.Id_classeGram > 0)
            {
                resultados = crud.SelecionarTabela("classegram", ClasseGramatical.ToListTabela(true), "Id=" + p.Id_classeGram.ToString());
                resClg = ClasseGramatical.ConverteObject(resultados);
                clg = resClg.First();
                ComboClasseGram.Text = clg.descricao;
            }
            if (p.referencia_verbete > 0)
            {
                resultados = crud.SelecionarTabela("referencias", Referencia.ToListTabela(true), "Id=" + p.referencia_verbete.ToString());
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

            numAcepcao.Value = p.acepcao; ///FIXME:bloquear a troca?
            textCultura.Text = p.nota_cultura;
            txtGramatica.Text = p.notas_gramatica;            
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
            btnEquiv.Enabled = true;
            btnConjuga.Enabled = true;
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
                if (ComboFiltroPrecisao.Text == "Precisamente")
                    resultados  = crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema='" + searchBox.Text + "'");
                else
                    resultados = crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema LIKE '%" + searchBox.Text + "%'");
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
                    InformaDiag.Erro("Nenhum resultado adequado encontrado.");
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (p.id <= 0 && txtpalavra.Text != "")
            {
                if (InformaDiag.ConfirmaSN("Existem dados não salvos. Caso prossiga com a operação, todos os dados" + '\n' + "digitados serão perdidos. Continuar mesmo assim?") == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(txtpalavra.Text == String.Empty)
            {
                InformaDiag.Erro("Palavra não pode ser vazio!");
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
            p.notas_gramatica = txtGramatica.Text;
            p.nota_cultura = textCultura.Text;
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

            if (p.id <= 0)
            {
                if (p.acepcao == 1)
                {
                    List<Conjugacao> lconj = new List<Conjugacao>();
                    Conjugacao conjugacao = new Conjugacao { preterito = "", presente = "", futuro = "" };
                    crud.InsereLinha(tabelasBd.CONJUGACAO,Conjugacao.ToListTabela(), conjugacao.ToListValores());
                    lconj = Conjugacao.ConverteObject(crud.SelecionarTabela("conjugacao", Conjugacao.ToListTabela(), "", "ORDER BY idconjugacao DESC LIMIT 2"));
                    p.id_conjuga = lconj.First().id;
                }
                else
                {
                    List<Palavra> ltemp = new List<Palavra>();
                    ltemp = Palavra.ConverteObject(crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema = '"+p.lema+"'", "LIMIT 2 "));
                    p.id_conjuga = ltemp.First().id_conjuga;
                }
                crud.InsereLinha(tabelasBd.PALAVRA, Palavra.ToListTabela(), p.ToListValores());
            }
            else
                crud.UpdateLine(tabelasBd.PALAVRA, Palavra.ToListTabela(), p.ToListValores(), "id=" + p.id.ToString());
            //Uma excessão pode ser lançda aqui quando os valores das chaves estrangerias forem <1, pois estão refernciando um valor que não existe. Como o int no c# não cabe um NULL, seria melhor não enviar o tal valor que evitamos o problema
            InformaDiag.Informa("Salvo!");
            LimpaCampos();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (InformaDiag.ConfirmaSN("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar"+ '\n' + "Prosseguir?") == DialogResult.Yes)
            {
                if (InformaDiag.ConfirmaOkCancel("Esta ação é irreversível! Confirme a exculsão.") == DialogResult.OK)
                {
                    crud.ApagaLinha(tabelasBd.PALAVRA, "Id=" + p.id.ToString());
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

        private void ComboClasseGram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboClasseGram.Text != "")
            {
                if(ComboClasseGram.Text.Length <= 3 )
                    clg = resClg.Find(clg => clg.sigla == ComboClasseGram.Text);
                else
                    clg = resClg.Find(clg => clg.descricao == ComboClasseGram.Text);
                p.Id_classeGram = clg.id;
            }
        }

        private void ComboClasseGram_TextUpdate(object sender, EventArgs e)
        {
            if (timerClg.Enabled == true) { timerClg.Enabled = false; timerClg.Enabled = true; } else timerClg.Enabled = true;
        }

        private void timerClg_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            pesquisa = ComboClasseGram.Text;
            if (ComboClasseGram.Items.Count > 0)
            {
                ComboClasseGram.Items.Clear();
            }
            if (pesquisa.Length <= 3)
            {
                resClg = ClasseGramatical.ConverteObject(crud.SelecionarTabela(tabelasBd.CLASSE_GRAMATICAL, ClasseGramatical.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10"));
            }
            else{
                resClg = ClasseGramatical.ConverteObject(crud.SelecionarTabela(tabelasBd.CLASSE_GRAMATICAL, ClasseGramatical.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10"));
            }
            foreach (ClasseGramatical c in resClg)
            {
                ComboClasseGram.Items.Add(c.descricao);
            }
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
                resRubrica = Rubrica.ConverteObject(crud.SelecionarTabela(tabelasBd.RUBRICA, Rubrica.ToListTabela(true), "sigla LIKE '" + pesquisa + "%'", "LIMIT 10"));
            }
            else
                resRubrica = Rubrica.ConverteObject(crud.SelecionarTabela(tabelasBd.RUBRICA, Rubrica.ToListTabela(true), "descricao LIKE '" + pesquisa + "%'", "LIMIT 10"));
            foreach (Rubrica r in resRubrica)
            {
                ComboRubrica.Items.Add(r.descricao);
            }
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
                resRef = Referencia.ConverteObject(crud.SelecionarTabela(tabelasBd.REFERENCIAS, Referencia.ToListTabela(true), "Descricao LIKE '%" + pesquisa + "%'", "LIMIT 10"));
                foreach (Referencia re in resRef)
                {
                    comboRef.Items.Add(re.descricao);
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
                p.referencia_verbete = refere.id;

            }
        }

        private void comboRef_TextUpdate(object sender, EventArgs e)
        {
            if (timerRef.Enabled == true) { timerRef.Enabled = false; timerRef.Enabled = true; } else timerRef.Enabled = true;
        }

        private void btnEquiv_Click(object sender, EventArgs e)
        {
            frm_Equivalente feq = new frm_Equivalente(p);
            feq.ShowDialog();
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
                InformaDiag.Informa("Salve as alterações antes de acessar as conjugações");
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
