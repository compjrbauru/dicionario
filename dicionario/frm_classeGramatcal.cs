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
    public partial class frm_CssGr : Form
    {
        ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        ClasseGramatical classe = new ClasseGramatical();
        public frm_CssGr()
        {
            InitializeComponent();
        }

        private void LimpaCampos() { txtDesc.Text = ""; txtSigla.Text = ""; }
        private void LimpaModel()
        {
            classe.descricao = "";
            classe.id = -1;
            classe.sigla = "";
        }
        private bool verificaCampos()
        {
            if (txtDesc.Text == "" || txtSigla.Text == "")
                return true;
            return false;
        }
        private void MostraModel()
        {
            txtDesc.Text = classe.descricao;
            txtSigla.Text = classe.sigla;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != classe.descricao || txtSigla.Text != classe.sigla)
            {
                if (MessageBox.Show("Existem dados não salvos que serão perdidos. \n Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" || txtSigla.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            classe.descricao = txtDesc.Text;
            classe.sigla = txtSigla.Text;
            if (classe.id > 0)
                conexao.UpdateLine("classegram", ClasseGramatical.ToListTabela(false), classe.ToListValores(), "id=" + classe.id.ToString());
            else
                conexao.InsereLinha("classegram", ClasseGramatical.ToListTabela(false), classe.ToListValores());
            LimpaCampos();
            LimpaModel();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (classe.id > 0)
            {
                if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        conexao.ApagaLinha("classegram", "Id=" + classe.id.ToString());
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
                List<string>[] resultado = conexao.Select("classegram", ClasseGramatical.ToListTabela(true), "sigla='" + txtSigla.Text + "'");
                if (resultado[0].Count > 0)
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < 3; i++)
                        temp.Add(resultado[i].ElementAt<string>(0));
                    classe = (ClasseGramatical)temp;
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
