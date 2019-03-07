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
using dicionario.Helpers;

namespace dicionario
{
    public partial class frm_Equivalente : Form
    {
        private CRUD crud = new CRUD();
        List<Equivalente> equivO = new List<Equivalente>();
        List<Equivalente> equivD = new List<Equivalente>();
        private int registroPai;
        public frm_Equivalente(int registroPai)
        {
            this.registroPai = registroPai;
            InitializeComponent();
        }

        private void frm_Equivalente_Load(object sender, EventArgs e)
        {
            equivO = Equivalente.ConverteObject(crud.SelecionarTabela(tabelasBd.EQUIVALENTE, Equivalente.ToListTabela(), "origem="+ registroPai.ToString()));
            equivO = Equivalente.ConverteObject(crud.SelecionarTabela(tabelasBd.EQUIVALENTE, Equivalente.ToListTabela(), "destino=" + registroPai.ToString()));
            
            throw new NotImplementedException();
        }
    }
}
