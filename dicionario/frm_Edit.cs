using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dicionario
{
    public partial class frm_Edit : Form
    {
        public frm_Edit()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
        }
    }
}
