using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class Palavra
    {
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

        public List<string> ToListValores()
        {
            List<string> val = new List<string>();
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

        public static List<string> ToListTabela()
        {

            List<string> val = new List<string>();
            val.Add("lema");
            val.Add("idioma");
            val.Add("heterogenerico");
            val.Add("heterotonico");
            val.Add("equivalente.ToString()");
            val.Add("referencia_verbete.ToString()");
            val.Add("referencia_exemplo");
            val.Add("notas_gramatica");
            val.Add("nota_cultura");
            val.Add("acepcao");
            val.Add("notas_gramatica_avancado");

            return val;
        }
    }

}