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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            ConectaBanco conecta = new ConectaBanco("dicionario", "root", "gamesjoker", "10.0.2.15");
            string temp;
            //campos não nulos: usuario, senha, nivel de permissão, email e cpf
            if (txtusr.Text == "" || txtpass.Text == "" || txtEmail.Text==""||txtCpf.Text=="")
                MessageBox.Show("Campos obrigatórios não foram preenchidos.");
            else
            {
                usr.usr = txtusr.Text;
                usr.pass = txtpass.Text;
                switch (comboPermissao.SelectedIndex)
                {
                    case 0:
                        temp = "ADM";
                        break;
                    case 1:
                        temp = "EDT";
                        break;
                    default:
                        temp = "USR";
                        break;
                }
                usr.permissao = temp;
                usr.email = txtEmail.Text;
                usr.nome = txtNome.Text;
                usr.contato = txtContato.Text;
                usr.rsocial = txtRSoc.Text;
                usr.cpf = txtCpf.Text;
                //...
                //...
                conecta.InsereLinha("usr", usr.ToListTabela(true),usr.ToListValores(true));
            }
        }

        private void frm_controledeusuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
