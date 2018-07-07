using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    public class Palavra
    {
        public int id { get; set; }
        public string lema { get; set; }
	    public int Id_catGram { get; set; }
	    public int Id_classeGram { get; set; }
        public string idioma { get; set; }
        public int rubrica { get; set; }
        public bool heterogenerico { get; set; }
        public bool heterotonico { get; set; }
        public int equivalente { get; set; }
        public int referencia_verbete { get; set; }
        public string referencia_exemplo { get; set; }
        public string notas_gramatica { get; set; }
        public string nota_cultura { get; set; }
        public int acepcao { get; set; }
        public bool heterossemantico { get; set; }
        public string ref_ex_tr { get; set; }
        public int Infinitivo { get; set; }

        public override string ToString()
        {
            string expressao = "lema=" + lema + "',idioma='" + idioma + "',heterogenerico='" + heterogenerico + "',heterotonico='" + heterotonico + "',equivalente='" + equivalente + "',referencia_verbete='" + referencia_verbete + "',referencia_exemplo='" + referencia_exemplo + "',notas_gramatica='" + notas_gramatica + "',notas_cultura='" + nota_cultura + "',acepcao='" + acepcao + "'";
            return expressao;
        }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(lema);
	        val.Add(Id_catGram.ToString());
	        val.Add(Id_classeGram.ToString());
            val.Add(idioma);
            val.Add(rubrica.ToString());
            val.Add(heterogenerico.ToString());
            val.Add(heterotonico.ToString());
            val.Add(equivalente.ToString());
            val.Add(referencia_verbete.ToString());
            val.Add(referencia_exemplo);
            val.Add(notas_gramatica);
            val.Add(nota_cultura);
            val.Add(acepcao.ToString());
            val.Add(heterossemantico.ToString());
            val.Add(ref_ex_tr);
            val.Add(Infinitivo.ToString());

            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("Lema");
	        val.Add("Id_catGram");
	        val.Add("Id_classeGram");
            val.Add("Idioma");
            val.Add("Rubrica");
            val.Add("heterogenerico");
            val.Add("heterotonico");
            val.Add("equivalente");
            val.Add("referencia_verbete");
            val.Add("referencia_exemplo");
            val.Add("notas_gramatica");
            val.Add("notas_cultura");
            val.Add("acepcao");
            val.Add("heterossemantico");
            val.Add("referencia_exemplo_tr");
            val.Add("Infinitivo");

            return val;
        }
        public static explicit operator Palavra(List<string> lista) //fazer um implicito?
        {
            Palavra p = new Palavra
            {
                id = int.Parse(lista.ElementAt(0)),
                lema = lista.ElementAt(1),
                Id_catGram = int.Parse(lista.ElementAt(2)),
                Id_classeGram = int.Parse(lista.ElementAt(3)),
                idioma = lista.ElementAt(4),
                rubrica = int.Parse(lista.ElementAt(5)),
                heterogenerico = Boolean.Parse(lista.ElementAt(6)),
                heterotonico = Boolean.Parse(lista.ElementAt(7)),
                equivalente = int.Parse(lista.ElementAt(8)),
                referencia_verbete = int.Parse(lista.ElementAt(9)),
                referencia_exemplo = lista.ElementAt(10),
                notas_gramatica = lista.ElementAt(11),
                nota_cultura = lista.ElementAt(12),
                acepcao = int.Parse(lista.ElementAt(13)),
                heterossemantico = Boolean.Parse(lista.ElementAt(14)),
                ref_ex_tr = lista.ElementAt(15),
                Infinitivo = int.Parse(lista.ElementAt(16))
            };
            return p;
        }
    }

}