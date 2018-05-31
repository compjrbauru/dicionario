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
    public partial class frm_controledeusuario : Form
    {
        public frm_controledeusuario()
        {
            InitializeComponent();
        }
        private ConectaBanco conecta = new ConectaBanco("dicionario", "root", "gamesjoker");
        Usuario usr = new Usuario();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LimpaCampo() {
            txtEmail.Text = String.Empty;
            txtNome.Text = String.Empty; 
            txtTelefone.Text = String.Empty; 
            txtRSoc.Text = String.Empty; 
            txtCpf.Text = String.Empty; 
            txtContato.Text = String.Empty;
            txtusr.Text= String.Empty;
            txtpass.Text = String.Empty;
        }
        private void LimpaModel()
        {
            usr.contato = "";
            usr.usr = "";
            usr.tel = "";
            usr.nome = "";
            usr.rsocial = "";
            usr.permissao = "";
            usr.pass = "";
            usr.cpf = "";
            usr.email = "";
        }
        private void MostraModel()
        {
            txtEmail.Text = usr.email;
            txtNome.Text = usr.nome;
            txtTelefone.Text = usr.tel;
            txtRSoc.Text = usr.rsocial;
            txtCpf.Text = usr.cpf;
            txtContato.Text = usr.contato;
            txtusr.Text = usr.usr;
            txtpass.Text = usr.pass;
            comboPermissao.Text = usr.permissao;

            switch (usr.permissao)
            {
                case "ADM":
                    comboPermissao.SelectedIndex = 0;
                    break;
                case "EDT":
                    comboPermissao.SelectedIndex = 1;
                    break;
                default:
                    comboPermissao.SelectedIndex = 2;
                    break;
            }
        }
        private string converteAutorizacao()
        {
            switch (comboPermissao.SelectedIndex)
            {
                case 0:
                    return "ADM";
                    
                case 1:
                    return "EDT";
                    
                default:
                    return "USR";
                  
            }
        }
        private void btnincluir_Click(object sender, EventArgs e)
        { 
            //campos não nulos: usuario, senha, nivel de permissão, email e cpf
            if (txtusr.Text == "" || txtpass.Text == "" || txtEmail.Text==""||txtCpf.Text=="")
                MessageBox.Show("Campos obrigatórios não foram preenchidos.");
            else
            {
                usr.usr = txtusr.Text;
                usr.pass = txtpass.Text;

                usr.permissao = converteAutorizacao();
                usr.email = txtEmail.Text;
                usr.nome = txtNome.Text;
                usr.tel = txtTelefone.Text;
                usr.rsocial = txtRSoc.Text;
                usr.cpf = txtCpf.Text;
                usr.contato = txtContato.Text;
                conecta.InsereLinha("usr", Usuario.ToListTabela(),usr.ToListValores());
                LimpaCampo();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                conecta.ApagaLinha("usr", "usr='" + txtusr.Text+"'");
            }
        }

        private void txtBuscaCpf_Click(object sender, EventArgs e)
        {
            List<string>[] resultado = conecta.Select("usr", Usuario.ToListTabela(),"cpf='"+txtCpf.Text+"'");
            if(resultado[0].Count > 0)
            {

            }
        }

        private void btnMostraSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
        }

        private void btnMostraSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (txtusr.Text != usr.usr || txtpass.Text != usr.pass || txtEmail.Text != usr.email || converteAutorizacao() != usr.permissao || txtCpf.Text != usr.cpf)
            {
                if (MessageBox.Show("Existem dados não salvos que serão perdidos. \n Deseja continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    return;
            }
            LimpaCampo();
            LimpaModel();
        }
    }
}
