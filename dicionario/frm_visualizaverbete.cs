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
        /*public frm_visualizaverbete(Palavra)
        {
            InitializeComponent();
            
        }*/
        public frm_visualizaverbete(Palavra Resultado) {
            InitializeComponent();
            /*List<string>[] coletor = new List<string>[5];
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
            lblLema.Text = Resultado.lema;*/
        }
        public frm_visualizaverbete(Palavra[] Resultado)
        {
            InitializeComponent();
            /*List<string>[] coletor = new List<string>[5];
            Rubrica ru;
            CategoriaGramatical cg;
            Referencia refer;
            int i = 0;
            coletor = bd.Select("rubrica", Rubrica.ToListTabela(true), "Id=" + Resultado.rubrica.ToString());
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
        private void PreencheTreeList(List<Palavra> entrada)
        {
            ConectaBanco bd = new ConectaBanco("dicionario", "root", "gamesjoker");
            CRUD operaBd = new CRUD();
            List<Rubrica> resRubrica = new List<Rubrica>();
            List<CategoriaGramatical> resCg = new List<CategoriaGramatical>();
            List<Referencia> resRefer = new List<Referencia>();
            Rubrica ru;
            CategoriaGramatical cg;
            Referencia refer;
            string filtro;
            List<int> v1 = new List<int>();
            List<int> v2 = new List<int>();
            List<int> v3 = new List<int>();

            foreach (Palavra p in entrada)
            {
                if (v1.Find(val => val == p.Id_catGram) < 0)
                {
                    v1.Add(p.Id_catGram);
                }
                if (v2.Find(val => val == p.rubrica) < 0)
                {
                    v2.Add(p.rubrica);
                }
                if (v3.Find(val => val == p.referencia_verbete) < 0)
                {
                    v3.Add(p.referencia_verbete);
                }
            }
            filtro = montaFiltro("id", v1); //filtrando cgram
            resCg = CategoriaGramatical.ConverteObject(operaBd.SelecionarTabela("categoriagram", CategoriaGramatical.ToListTabela(true), filtro));
            filtro = montaFiltro("id", v2); //filtrando rubrica
            resRubrica = Rubrica.ConverteObject(operaBd.SelecionarTabela("rubrica", Rubrica.ToListTabela(true), filtro));
            filtro = montaFiltro("Cod", v3);
            resRefer = Referencia.ConverteObject(operaBd.SelecionarTabela("referencias", Referencia.ToListTabela(true), filtro));

        }
        private string montaFiltro(string nomeCampo, List<int> valores) {
            String retorno = (nomeCampo + "=" + valores.First().ToString());
            for (int i = 1; i < valores.Count; i++)
            {
                retorno += (" OR " + nomeCampo + "=" + valores.ElementAt(i));
            }
            return retorno;
        }
        /*private TreeNode[] criaTreeNodes(List<string> valores) {
            IEnumerator<string> i;
            i.
            TreeNode[] tnm = new TreeNode[valores.Count];
            tnm
        }*/
        private void frm_visualizaverbete_Load(object sender, EventArgs e)
        {
             
            
        }
    }
}
