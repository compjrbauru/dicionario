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
    public partial class frm_Equivalente : Form
    {
        private CRUD crud = new CRUD();
        List<Equivalente> equivO = new List<Equivalente>();
        List<Equivalente> equivD = new List<Equivalente>();
        List<Palavra> resP = new List<Palavra>();
        private readonly Palavra registroPai;
        private Equivalente ativo = new Equivalente();
        private bool regsAtivo = true;
        private int posLista = 0;
        public frm_Equivalente(Palavra registroPai)
        {
            this.registroPai = registroPai;
            InitializeComponent();
        }

        private void configuraLabelOrgiem(Palavra item)
        {
            lblOrigem.Text = item.lema + " Acepção " + item.acepcao.ToString();
        }

        private void MostraRegistroAtivo()
        {
            chkHtonico.Checked = ativo.heterotonico;
            chkHsemantico.Checked = ativo.heterossemantico;
            chkHgenerico.Checked = ativo.heterogenerico;
            comboDestino.Text = "";
        }

        private void LimpaCampos()
        {
            chkHtonico.Checked = false;
            chkHsemantico.Checked = false;
            chkHgenerico.Checked = false;
            comboDestino.Text = "";
            comboDestino.SelectedIndex = 0;

            ativo.InvalidarDestino();

        }

        private void frm_Equivalente_Load(object sender, EventArgs e)
        {
            configuraLabelOrgiem(registroPai);
            equivO = Equivalente.ConverteObject(crud.SelecionarTabela(tabelasBd.EQUIVALENTE, Equivalente.ToListTabela(), "origem="+ registroPai.id.ToString()));
            equivD = Equivalente.ConverteObject(crud.SelecionarTabela(tabelasBd.EQUIVALENTE, Equivalente.ToListTabela(), "destino=" + registroPai.id.ToString()));
            throw new NotImplementedException();
        }
        
        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (posLista > 0)
            {
                posLista = 0;
                if (regsAtivo)
                {
                    ativo = equivO.First();
                }
                else
                {
                    ativo = equivD.First();
                }
                MostraRegistroAtivo();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posLista > 0)
            {
                posLista--;
                if (regsAtivo)
                {
                    ativo = equivO.ElementAt(posLista);
                }
                else
                {
                    ativo = equivD.ElementAt(posLista);
                }
                MostraRegistroAtivo();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (regsAtivo && posLista < equivO.Count)
            {
                ativo = equivO.ElementAt(++posLista);
            }
            if (!regsAtivo && posLista < equivD.Count)
            {
                ativo = equivD.ElementAt(++posLista);
            }
            MostraRegistroAtivo();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (regsAtivo && posLista < equivO.Count)
            {
                ativo = equivO.Last();
                posLista = equivO.Count - 1;
            }
            if (!regsAtivo && posLista < equivD.Count)
            {
                ativo = equivD.Last();
                posLista = equivD.Count - 1;
            }
            MostraRegistroAtivo();
        }
        private void btnNovo_Click (object sender, EventArgs e)
        {
            LimpaCampos();
            ativo.SetOrigem(registroPai.id);
        }

        private void btnApaga_Click(object sender, EventArgs e){
            if (InformaDiag.ConfirmaSN("Deseja realmente apagar o relacionamento?\nA ação é irreversível!") == DialogResult.Yes)
            {
                crud.ApagaLinha(tabelasBd.EQUIVALENTE, "origem=" + ativo.origem.ToString() + " AND destino=" + ativo.destino.ToString());
                LimpaCampos();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            crud.UpdateLine(tabelasBd.EQUIVALENTE, Equivalente.ToListTabela(), ativo.ToListValores());
            InformaDiag.InformaSalvo();
        }

        private void btnVisao_Click(object sender, EventArgs e){
            if (regsAtivo)
            {
                regsAtivo = false;
                ativo = equivD.First();
                btnVisao.Text = "Mostrar ativos";
            }
            else
            {
                regsAtivo = true;
                ativo = equivO.First();
                btnVisao.Text = "Mostrar estrangeiros";
            }
            MostraRegistroAtivo();
        }

        private void timerDestino_Tick(object sender, EventArgs e)
        {
            string pesquisa = comboDestino.Text;
            comboDestino.Items.Clear();
            if (pesquisa.Length > 0)
            {
                resP = Palavra.ConverteObject(crud.SelecionarTabela(tabelasBd.PALAVRA, Palavra.ToListTabela(true), "lema='" + pesquisa + "'", "LIMIT 25"));
                foreach (Palavra p in resP)
                {
                    comboDestino.Items.Add(p.lema + " Acpc " + p.acepcao.ToString() + " ");
                }
            }
            timerDestino.Enabled = false;
        }

        private void comboDestino_TextUpdate(object sender, EventArgs e)
        {
            if (timerDestino.Enabled)
            {
                timerDestino.Enabled = false;
                timerDestino.Enabled = true;
            } else
            {
                timerDestino.Enabled = true;
            }
        }

        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDestino.Text != "")
            {
                ativo.SetDestino(resP.ElementAt(comboDestino.SelectedIndex).id);
            }
        }
    }
}
