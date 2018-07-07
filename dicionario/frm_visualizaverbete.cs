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
    public partial class frm_visualizaverbete : Form
    {
        Palavra p;
        ConectaBanco bd = new ConectaBanco("dicionario", "root", "gamesjoker");
        /*public frm_visualizaverbete(Palavra)
        {
            InitializeComponent();
            
        }*/
        public frm_visualizaverbete(Palavra Resultado) {
            InitializeComponent();
            p = Resultado;
        }
        private void frm_visualizaverbete_Load(object sender, EventArgs e)
        {
            lblLema.Text = p.lema;
        }
    }
}
