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
	    //public int Id_catGram { get; set; }
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
        public string equivalente_pluriv { get; private set; } = "{-1}";
        public int id_conjuga { get; set; }
        public string Genero { get; set; }
        public string Definicao { get; set; }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(lema);
            //val.Add(Id_catGram.ToString());
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
            if (equivalente > 1)
                equivalente_pluriv = "{-1}";
            val.Add(equivalente_pluriv);
            val.Add(id_conjuga.ToString());
            val.Add(Genero);
            //val.Add(Definicao);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("Lema");
	        val.Add("Id_catGram");
	        
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
            val.Add("equivalente_pluriv");
            val.Add("Id_conjuga");
            val.Add("Genero");
            //val.Add("Definicao");
            return val;
        }
        public void EditRelacoesPluri(List<int> relacionamento)
        {
            string espacos = "";
            int max = relacionamento.Count();
                for (int i = 0; i < max; i++)
                {
                    espacos += "{" + relacionamento.ElementAt(i).ToString() + "}";
                }
            equivalente_pluriv = espacos;
        }
        private void ChecaOperador(string entrada) {
            if (!(entrada.Contains("{") && entrada.Contains("}")))
                equivalente_pluriv = "{-1}";
            else
            {
                equivalente_pluriv = entrada;
            }
        }
        public static List<Palavra> ConverteObject(List<object[]> entrada)
        {
            List<Palavra> s = new List<Palavra>();
            int lim = entrada.Count;
            Palavra pt = new Palavra();
            object[] po = new object[Palavra.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Palavra)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Palavra(List<string> lista) //fazer um implicito?
        {
            ///TODO: para evitar problemas de estouro, usar um contador simples autoincementável para pegar os valores. Exemplo{ int i = 0; id = int.parse(list.elementat(i++),...}
            Palavra p = new Palavra
            {
                id = int.Parse(lista.ElementAt(0)),
                lema = lista.ElementAt(1),
                //Id_catGram = int.Parse(lista.ElementAt(2)),
                Id_classeGram = int.Parse(lista.ElementAt(2)),
                Genero = lista.ElementAt(18),
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
                Infinitivo = int.Parse(lista.ElementAt(16)),
                //id_conjuga = int.Parse(lista.ElementAt(18))
                Definicao = lista.ElementAt(19)
            };
            p.ChecaOperador(lista.ElementAt(17));
            return p;
        }
        public static explicit operator Palavra(object[] lista)
        {
            Palavra saida = new Palavra {
                id = int.Parse(lista[0].ToString()),
                lema = lista[1].ToString(),
                //Id_catGram = int.Parse(lista[2].ToString()),
                Id_classeGram = int.Parse(lista[2].ToString()),
                Genero = lista[18].ToString(),
                idioma = lista[4].ToString(),
                rubrica = int.Parse(lista[5].ToString()),
                heterogenerico = Boolean.Parse(lista[6].ToString()),
                heterotonico = Boolean.Parse(lista[7].ToString()),
                equivalente = int.Parse(lista[8].ToString()),
                referencia_verbete = int.Parse(lista[9].ToString()),
                referencia_exemplo = lista[10].ToString(),
                notas_gramatica = lista[11].ToString(),
                nota_cultura = lista[12].ToString(),
                acepcao = int.Parse(lista[13].ToString()),
                heterossemantico = Boolean.Parse(lista[14].ToString()),
                ref_ex_tr = lista[15].ToString(),
                Infinitivo = int.Parse(lista[16].ToString())//,
                //id_conjuga = int.Parse(lista.ElementAt(18))
                //Definicao = lista[19].ToString()
            };
            saida.ChecaOperador(lista[17].ToString());
            return saida;
        }
        
    }

}