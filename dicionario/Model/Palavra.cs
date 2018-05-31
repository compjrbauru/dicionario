using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class Palavra
    {
        public int id { get; set; }
        public string lema { get; set; }
        public string idioma { get; set; }
        public string heterogenerico { get; set; }
        public string heterotonico { get; set; }
        public int equivalente { get; set; }
        public int referencia_verbete { get; set; }
        public string referencia_exemplo { get; set; }
        public string notas_gramatica { get; set; }
        public string nota_cultura { get; set; }
        public string acepcao { get; set; }
        public string notas_gramatica_avancado { get; set; }

        public override string ToString()
        {
            string expressao = "lema=" + lema + "',idioma='" + idioma + "',heterogenerico='" + heterogenerico + "',heterotonico='" + heterotonico + "',equivalente='" + equivalente +
                "',referencia_verbete='" + referencia_verbete + "',referencia_exemplo='" + referencia_exemplo + "',notas_gramatica='" + notas_gramatica +
                "',nota_cultura='" + nota_cultura + "',acepcao='" + acepcao + "',notas_gramatica_avancado='" + notas_gramatica_avancado + "'";
            return expressao;
        }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(lema);
            val.Add(idioma);
            val.Add(heterogenerico);
            val.Add(heterotonico);
            val.Add(equivalente.ToString());
            val.Add(referencia_verbete.ToString());
            val.Add(referencia_exemplo);
            val.Add(notas_gramatica);
            val.Add(nota_cultura);
            val.Add(acepcao);
            val.Add(notas_gramatica_avancado);

            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("lema");
            val.Add("idioma");
            val.Add("heterogenerico");
            val.Add("heterotonico");
            val.Add("equivalente");
            val.Add("referencia_verbete");
            val.Add("referencia_exemplo");
            val.Add("notas_gramatica");
            val.Add("nota_cultura");
            val.Add("acepcao");
            val.Add("notas_gramatica_avancado");

            return val;
        }
        public static explicit operator Palavra(List<string> lista)
        {
            Palavra p = new Palavra
            {
                id = int.Parse(lista.ElementAt(0)),
                lema = lista.ElementAt(1),
                idioma = lista.ElementAt(2),
                heterogenerico = lista.ElementAt(3),
                heterotonico = lista.ElementAt(4),
                equivalente = int.Parse(lista.ElementAt(5)),
                referencia_verbete = int.Parse(lista.ElementAt(6)),
                referencia_exemplo = lista.ElementAt(7),
                notas_gramatica = lista.ElementAt(8),
                nota_cultura = lista.ElementAt(9),
                acepcao = lista.ElementAt(10),
                notas_gramatica_avancado = lista.ElementAt(11),
            };
            return p;
        }
    }

}