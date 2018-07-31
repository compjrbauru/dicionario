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
            List<string>[] coletor = new List<string>[5];
            Rubrica ru;
            CategoriaGramatical cg;
            Referencia refer;
            int i = 0;
            coletor = bd.Select("rubrica", Rubrica.ToListTabela(true), "Id=" + Resultado.rubrica.ToString());
            ru = (Rubrica)coletor;
            coletor = bd.Select("categoriagram",CategoriaGramatical.ToListTabela(true),"Id=" + Resultado.Id_catGram.ToString());
            cg = (CategoriaGramatical)coletor;
            coletor = bd.Select("referencias",Referencia.ToListTabela(true),"Cod=" + Resultado.referencia_verbete.ToString());
            refer = (Referencia)coletor;
            p = Resultado;
            TreeNode[] nodecoll = new TreeNode[] {new TreeNode(cg.Definicao), new TreeNode (p.referencia_exemplo), new TreeNode (p.ref_ex_tr), new TreeNode (refer.descricao), new TreeNode(p.notas_gramatica), new TreeNode(p.nota_cultura) };
            TreeNode[] teste = new TreeNode[] {new TreeNode(cg.descricao,new TreeNode[] { nodecoll[i++] }), new TreeNode(ru.descricao), new TreeNode("Exemplos de uso",new TreeNode[] {nodecoll[i++], nodecoll[i++], nodecoll[i++] }), new TreeNode("Notas Gramaticais", new TreeNode[] { nodecoll[i++] }), new TreeNode("Notas culturais", new TreeNode[] { nodecoll[i++] })  };
            TrvPalavra.Nodes.AddRange(teste);
            lblLema.Text = Resultado.lema;
        }
        public frm_visualizaverbete(Palavra[] Resultado)
        {
            InitializeComponent();
            List<string>[] coletor = new List<string>[5];
            Rubrica ru;
            CategoriaGramatical cg;
            Referencia refer;
            int i = 0;
            /*coletor = bd.Select("rubrica", Rubrica.ToListTabela(true), "Id=" + Resultado.rubrica.ToString());
            ru = (Rubrica)coletor;
            coletor = bd.Select("categoriagram", CategoriaGramatical.ToListTabela(true), "Id=" + Resultado.Id_catGram.ToString());
            cg = (CategoriaGramatical)coletor;
            coletor = bd.Select("referencias", Referencia.ToListTabela(true), "Cod=" + Resultado.referencia_verbete.ToString());
            refer = (Referencia)coletor;
            p = Resultado;
            TreeNode[] nodecoll = new TreeNode[] { new TreeNode(cg.Definicao), new TreeNode(p.referencia_exemplo), new TreeNode(p.ref_ex_tr), new TreeNode(refer.descricao), new TreeNode(p.notas_gramatica), new TreeNode(p.nota_cultura) };
            TreeNode[] teste = new TreeNode[] { new TreeNode(cg.descricao, new TreeNode[] { nodecoll[i++] }), new TreeNode(ru.descricao), new TreeNode("Exemplos de uso", new TreeNode[] { nodecoll[i++], nodecoll[i++], nodecoll[i++] }), new TreeNode("Notas Gramaticais", new TreeNode[] { nodecoll[i++] }), new TreeNode("Notas culturais", new TreeNode[] { nodecoll[i++] }) };
            TrvPalavra.Nodes.AddRange(teste);
            lblLema.Text = ;*/
        }
        private void frm_visualizaverbete_Load(object sender, EventArgs e)
        {
             
            
        }
    }
}
