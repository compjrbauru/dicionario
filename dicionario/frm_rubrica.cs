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

namespace dicionario.Model
{
    public partial class frm_rubrica : Form
    {
        ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        Rubrica rubrica = new Rubrica();
        public frm_rubrica()
        {
            InitializeComponent();
        }
        private void LimpaCampos() { txtDesc.Text = ""; txtSigla.Text = ""; }
        private void LimpaModel()
        {
            rubrica.descricao = "";
            rubrica.id = -1;
            rubrica.sigla = "";
        }
        private bool verificaCampos() {
            if (txtDesc.Text == "" || txtSigla.Text == "")
                return true;
            return false;
        }
        private void MostraModel()
        {
            txtDesc.Text = rubrica.descricao;
            txtSigla.Text = rubrica.sigla;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != rubrica.descricao || txtSigla.Text != rubrica.sigla)
            {
                if(MessageBox.Show("Existem dados não salvos que serão perdidos. \n Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if(txtDesc.Text == "" || txtSigla.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            rubrica.descricao = txtDesc.Text;
            rubrica.sigla = txtSigla.Text;
            if (rubrica.id > 0)
                conexao.UpdateLine("rubrica", Rubrica.ToListTabela(false), rubrica.ToListValores(), "id=" + rubrica.id.ToString());
            else
                conexao.InsereLinha("rubrica", Rubrica.ToListTabela(false), rubrica.ToListValores());
            LimpaCampos();
            LimpaModel();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (rubrica.id>0)
            {
                if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        conexao.ApagaLinha("rubrica", "Id=" + rubrica.id.ToString());
                        LimpaModel();
                        LimpaCampos();
                    }
                }
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtSigla.Text != "")
            {
                List<string>[] resultado = conexao.Select("rubrica", Rubrica.ToListTabela(true), "sigla='" + txtSigla.Text + "'");
                if (resultado[0].Count > 0)
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < 4; i++)
                        temp.Add(resultado[i].ElementAt<string>(0));
                    rubrica = (Rubrica)temp;
                    MostraModel();
                }
                else
                {
                    MessageBox.Show("Nenhum resultado encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
