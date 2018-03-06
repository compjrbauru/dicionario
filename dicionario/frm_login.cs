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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            ConectaBanco conecta = new ConectaBanco("bd","login","pass");
            List<string>[] list = new List<string>[1];    
            if (txtusuario.Text == "" || txtsenha.Text == "")
                MessageBox.Show("Usurio e(ou) senha não foram preenchidos. Por favor verifique os campos.");
            else
            {
                list = conecta.Select("usr", usr.ToListTabela(), "usr='" + txtusuario.Text + "', pass='" + txtsenha.Text + "'");
                if (list[0].Count<string>() == 0)
                {
                    MessageBox.Show("Combinação de usuário e senha não existe.");
                    txtsenha.Text = "";
                }
                else
                {
                    //Usuario autorizado
                    return;
                }
            }
        }
    }
}
