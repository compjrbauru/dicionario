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
        public frm_visualizaverbete()
        {
            InitializeComponent();
        }
        string p;
        ConectaBanco bd = new ConectaBanco("dicionario", "root", "senha");
        private void frm_visualizaverbete_Load(object sender, EventArgs e)
        {

        }
    }
}
