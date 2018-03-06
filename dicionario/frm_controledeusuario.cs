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
            ConectaBanco conecta = new ConectaBanco("bd", "usr", "pass");
            //campos não nulos: usuario, senha, nivel de permissão, email e cpf
            if (txtusr.Text == "")
                MessageBox.Show("Campos obrigatórios não foram preenchidos.");
            else
            {
                usr.usr = txtusr.Text;
                //...
                //...
                conecta.InsereLinha("usr", usr.ToListTabela(),usr.ToListValores());
            }
        }
    }
}
