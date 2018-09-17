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
    public partial class frm_conjuga : Form
    {
        Conjugacao conjuga = new Conjugacao();
        public frm_conjuga()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///TODO: Sugerir que as informações nas textboxes sejam quebradas uma por linha. A apresentação das informçãoes de cada uma delas será contolada pelo CHR(13) na exibição do lema
        }

        private void frm_conjuga_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpaPr_Click(object sender, EventArgs e)
        {
            txtPreterito.Text = String.Empty;
        }

        private void btnLimpaPe_Click(object sender, EventArgs e)
        {
            txtPresente.Text = String.Empty;
        }

        private void btnLimpaFu_Click(object sender, EventArgs e)
        {
            txtFuturo.Text = String.Empty;
        }
    }
}
