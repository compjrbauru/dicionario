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
        private MarcaUso rb = new MarcaUso();
        private Referencia refere = new Referencia();
        private List<object[]> resultados;
        private List<Palavra> resPalavra = new List<Palavra>();
        private int ipal = 0;
        private List<MarcaUso> resRubrica = new List<MarcaUso>();
        private List<Referencia> resRef = new List<Referencia>();
        private bool Sin1Ativo = true;
        private List<Palavra> resSin = new List<Palavra>();

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
        private void LimpaCampos()
        {
            txtDefinicao.Text = "";
            //txtGramatica.Text = "";
            txtpalavra.Text = "";
            ComboClasseGram.SelectedIndex = -1;
            ComboClasseGram.Text = "";
            ComboGenero.SelectedIndex = -1;
            ComboGenero.Text = "";
            ComboIdioma.SelectedIndex = -1;
            ComboIdioma.Text = "";
            //textCultura.Text = "";
            btnEquiv.Enabled = false;
            btnConjuga.Enabled = false;
            comboSinonimo1.Text = "";
            comboSinonimo1.Items.Clear();
            comboSinonimo2.Text = "";
            comboSinonimo2.Items.Clear();
            txtSubLema.Text = "";
        }
        private void LimpaModel()
        {
            p.id = -1;
            p.lema = "";
            p.Genero = "N";
            p.Sinonimo1 = -1;
            p.Sinonimo2 = -1;
            p.Sublema = "";
        }
        private void MostraDados()
        {
            txtpalavra.Text = p.lema;
            if (p.idioma == "PT")
                ComboIdioma.SelectedIndex = 0;
            else
            {
                if (p.idioma == "ES")
                    ComboIdioma.SelectedIndex = 1;
                else
                {
                    ComboIdioma.SelectedIndex = 2;
                }
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
                case "S":
                    ComboGenero.SelectedIndex = 3;
                    break;
                case "SM":
                    ComboGenero.SelectedIndex = 4;
                    break;
            }
            ComboClasseGram.Text = p.ClasseGram;
            btnEquiv.Enabled = true;
            btnConjuga.Enabled = true;
            if (p.Sinonimo1 > 0)
            {
                string filtro = "id=" + p.Sinonimo1.ToString();
                if (p.Sinonimo2 > 0) filtro += (" OR id=" + p.Sinonimo2.ToString());
                resSin = Palavra.ConverteObject(crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), filtro));
                comboSinonimo1.Text = resSin.First().lema;
                if (resSin.Count > 1)
                comboSinonimo2.Text = resSin.ElementAt(1).lema; 
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
            if (txtpalavra.Text != "")
            {
                if (InformaDiag.ConfirmaSN("Existem dados não salvos. Caso prossiga com a operação, todos os dados" + '\n' + "digitados serão perdidos. Continuar mesmo assim?") == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private string PegaSiglaIdioma(){
            switch (ComboIdioma.SelectedIndex)
            {
                case 0:
                    return "PT";
                case 2:
                    return "EN";
                    
                case 1:
                    return "ES";
                    
                default:
                    return "";
                    
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            bool r;
            if(txtpalavra.Text == String.Empty)
            {
                InformaDiag.Erro("Palavra não pode ser vazio!");
                return;
            }
            if (ComboClasseGram.SelectedItem == null)
            {
                InformaDiag.Erro("Selecione um valor válido de Classe gramatical!");
                return;
            }
            if (ComboGenero.SelectedItem == null)
            {
                InformaDiag.Erro("Selecione um gênero válido!");
                return;
            }
            if (ComboIdioma.SelectedItem == null)
            {
                InformaDiag.Erro("É obrigatório selecionar um idioma!");
                return;
            }
            p.lema = txtpalavra.Text;
            p.idioma = PegaSiglaIdioma();
            p.Definicao = txtDefinicao.Text;
            switch (ComboGenero.SelectedIndex)
            {
                case 0:
                    p.Genero = "M";
                    break;
                case 1:
                    p.Genero = "F";
                    break;
                case 2:
                    p.Genero = "N";
                    break;
                case 3:
                    p.Genero = "S";
                    break;
                case 4:
                    p.Genero = "SM";
                    break;
                default:
                    throw new Exception("Opção não disponível na lista de opções de gênero.");
            }
            if (p.Genero == "N" && p.idioma == "PT")
            {
                InformaDiag.Erro("Gênero inadequado ao idioma.");
                return;
            }
            p.ClasseGram = ComboClasseGram.Text;
            if (comboSinonimo1.Text == "") p.Sinonimo1 = 0;
            if (comboSinonimo2.Text == "") p.Sinonimo2 = 0;
            p.Sublema = txtSubLema.Text;
            AjustaSinonimos();
            if (p.id <= 0)
            {
                r = crud.InsereLinha(tabelasBd.PALAVRA, Palavra.ToListTabela(), p.ToListValores());
            }
            else
                 r = crud.UpdateLine(tabelasBd.PALAVRA, Palavra.ToListTabela(), p.ToListValores(), "id=" + p.id.ToString());
            //Uma excessão pode ser lançda aqui quando os valores das chaves estrangerias forem <1, pois estão refernciando um valor que não existe. Como o int no c# não cabe um NULL, seria melhor não enviar o tal valor que evitamos o problema
            if (r)
                InformaDiag.Informa("Salvo!");
            LimpaCampos();
            LimpaModel();
        }

        private void AjustaSinonimos()
        {
            if (p.Sinonimo2 > 0 && p.Sinonimo1 < 1)
            {
                p.Sinonimo1 = p.Sinonimo2;
                p.Sinonimo2 = 0;
            }
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
            frm_mUso _Rubrica = new frm_mUso();
            _Rubrica.ShowDialog();
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

        private void btnEquiv_Click(object sender, EventArgs e)
        {
            frm_Equivalente feq = new frm_Equivalente(p);
            feq.ShowDialog();
        }

        private void btnConjuga_Click(object sender, EventArgs e)
        {
                frm_conjuga fc = new frm_conjuga(p.id);
            fc.ShowDialog();
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

        private void timerSinonimo_Tick(object sender, EventArgs e)
        {
            string pesquisa;
            if (Sin1Ativo)
            {
                pesquisa = comboSinonimo1.Text;
                comboSinonimo1.Items.Clear();
            }
            else
            {
                pesquisa = comboSinonimo2.Text;
                comboSinonimo2.Items.Clear();
            }
            if (pesquisa.Length > 0)
            {
                string idioma = p.idioma;
               if (idioma == "" || idioma == null) idioma = PegaSiglaIdioma();
                if (idioma != "")
                    resSin = Palavra.ConverteObject(crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema LIKE '%" + pesquisa + "%' AND Idioma='" + idioma + "'", "LIMIT 10"));
                if (Sin1Ativo)
                {
                    foreach (Palavra p in resSin)
                    {
                        comboSinonimo1.Items.Add(p.lema);
                    }
                }
                else
                {
                    foreach (Palavra p in resSin)
                    {
                        comboSinonimo2.Items.Add(p.lema);
                    }
                }
            }
            timerSinonimo.Enabled = false;
        }

        private void TimerSwitcher()
        {
            if (timerSinonimo.Enabled)
            {
                timerSinonimo.Enabled = false;
                timerSinonimo.Enabled = true;
            }
            else
            {
                timerSinonimo.Enabled = true;
            }
        }

        private void comboSinonimo1_TextUpdate(object sender, EventArgs e)
        {
            TimerSwitcher();
            Sin1Ativo = true;
        }

        private void comboSinonimo2_TextUpdate(object sender, EventArgs e)
        {
            TimerSwitcher();
            Sin1Ativo = false;
        }

        private void comboSinonimo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSinonimo1.Text != "")
                p.Sinonimo1 = resSin.Find(pal => pal.lema == comboSinonimo1.Text).id;
        }

        private void comboSinonimo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSinonimo2.Text != "")
                p.Sinonimo2 = resSin.Find(pal => pal.lema == comboSinonimo2.Text).id;
        }
    }
}
