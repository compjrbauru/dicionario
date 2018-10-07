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
    public partial class frm_referencia : Form
    {
        ConectaBanco conexao = new ConectaBanco("dicionario", "root", "gamesjoker");
        Referencia referencia = new Referencia();
        CRUD c = new CRUD();
        List<Referencia> resultado = new List<Referencia>();
        int p = 0;
        public frm_referencia()
        {
            InitializeComponent();
        }
        private void LimpaCampos() {
            txtAno.Text = "";
            txtDesc.Text = "";
            txtAutor.Text = "";
            txtCod.Text = "";
        }
        private void LimpaModel()
        {
            referencia.descricao = "";
            referencia.ano = 0;
            referencia.autor = "";
            referencia.Cod = -1;
            txtCod.ReadOnly = false;
        }
        private void MostraModel() {
            txtDesc.Text = referencia.descricao;
            txtAno.Text = referencia.ano.ToString();
            txtAutor.Text = referencia.autor;
            txtCod.Text = referencia.Cod.ToString();
        }
        private bool verificaCampos()
        {
            if (txtAutor.Text == "" || txtAno.Text == "")
                return true;
            return false;
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            resultado = Referencia.ConverteObject(c.SelecionarTabela("referencias", Referencia.ToListTabela(true), "Cod='" + txtCodPSQ.Text + "'"));
            if (resultado.Count < 1) {
                MessageBox.Show("Nenhum resultado encontrado.", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            referencia = resultado.First();
            MostraModel();
            if (resultado.Count > 1)
            {
                btnAnt.Visible = true;
                btnProx.Visible = true;
            }
            p = 0;
            txtCod.ReadOnly = true;
        }
        private void btnAnt_Click (object sender, EventArgs e)
        {
            if (p > 0)
            {
                referencia = resultado.ElementAt(--p);
                MostraModel();
            }
        }

        private void btnProx_Click (object sender, EventArgs e)
        {
            if(p < resultado.Count)
            {
                referencia = resultado.ElementAt(++p);
                MostraModel();
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != referencia.descricao || txtAno.Text != referencia.ano.ToString() || txtAutor.Text != referencia.autor)
            {
                if (MessageBox.Show("Existem dados não salvos que serão perdidos. \n Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
            }
            LimpaCampos();
            LimpaModel();
            
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" || txtAno.Text == "" || txtAutor.Text == "")
            {
                MessageBox.Show("Existem campos obrigatórios vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            referencia.descricao = txtDesc.Text;
            referencia.ano = int.Parse(txtAno.Text);
            referencia.autor = txtAutor.Text;
            if (referencia.Cod > 0) { 
                c.UpdateLine("referencias", Referencia.ToListTabela(false), referencia.ToListValores(), "Cod=" + referencia.Cod.ToString());
            LimpaCampos();
            LimpaModel(); }
            else
            {
                c.InsereLinha("referencias", Referencia.ToListTabela(false), referencia.ToListValores()); 
                ///FIXME:o valor da referência é manual?
                MessageBox.Show("Salvo!");
            }
            
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (referencia.Cod > 0)
            {
                if (MessageBox.Show("Remover um registro pode afetar vários outros. Recomenda-se observar as dependências antes de continuar" + '\n' + "Prosseguir?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Esta ação é irreversível! Confirme a exculsão.", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        c.ApagaLinha("referencias", "Cod=" + referencia.Cod.ToString());
                        resultado.RemoveAt(p);
                        if (resultado.Count > 0)
                        {
                            try
                            {
                                referencia = resultado.ElementAt(--p);
                            }
                            catch (IndexOutOfRangeException)
                            {
                                referencia = resultado.ElementAt(++p);
                            }
                            MostraModel();
                        }
                        else {
                            LimpaModel();
                            LimpaCampos();
                        }
                        
                    }
                }
            }
        }
    }
}
