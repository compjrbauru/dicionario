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
        //public int rubrica { get; set; }
        //public int referencia_verbete { get; set; }
        //public string referencia_exemplo { get; set; }
        public string notas_gramatica { get; set; }
        public string nota_cultura { get; set; }
        public int acepcao { get; set; }
        //public string ref_ex_tr { get; set; }
        public int Infinitivo { get; set; }
        //public string equivalente_pluriv { get; private set; } = "{-1}";
        public int id_conjuga { get; set; }
        public string Genero { get; set; }
        public string Definicao { get; set; }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(lema);
            val.Add(Id_classeGram.ToString());
            val.Add(idioma);
            val.Add(notas_gramatica);
            val.Add(nota_cultura);
            val.Add(acepcao.ToString());
            val.Add(Infinitivo.ToString());
            val.Add(id_conjuga.ToString());
            val.Add(Genero);
            val.Add(Definicao);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("Lema");
	        val.Add("Id_classeGram");
            val.Add("Idioma");
            val.Add("notas_gramatica");
            val.Add("notas_cultura");
            val.Add("acepcao");
            val.Add("Infinitivo");
            val.Add("Id_conjuga");
            val.Add("Genero");
            val.Add("Definicao");
            return val;
        }
        /*public void EditRelacoesPluri(List<int> relacionamento)
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
        }*/
        public static List<Palavra> ConverteObject(List<object[]> entrada)
        {
            List<Palavra> s = new List<Palavra>();
            int lim = entrada.Count;
            Palavra pt = new Palavra();
            object[] po = new object[ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Palavra)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Palavra(List<string> lista)
        {
            int i = 0;
            Palavra p = new Palavra();
            if (int.TryParse(lista[i].ToString(),out int result))
            {
                p.id = result;
                i++;
            }
            p.lema = lista.ElementAt(i++);
            p.Id_classeGram = int.Parse(lista.ElementAt(i++));        
            p.idioma = lista.ElementAt(i++);
            p.notas_gramatica = lista.ElementAt(i++);
            p.nota_cultura = lista.ElementAt(i++);
            p.acepcao = int.Parse(lista.ElementAt(i++));
            p.Infinitivo = int.Parse(lista.ElementAt(i++));
           // p.ChecaOperador(lista.ElementAt(i++));
            p.id_conjuga = int.Parse(lista.ElementAt(i++));
            p.Genero = lista.ElementAt(i++);
            p.Definicao = lista.ElementAt(i++);
            return p;
        }
        public static explicit operator Palavra(object[] lista)
        {
            Palavra saida = new Palavra();
            int i = 0;
            if (int.TryParse(lista[i].ToString(), out int resul))
            {
                saida.id = resul;
                i++;
            }
            saida.lema = lista[i++].ToString();
            saida.Id_classeGram = int.Parse(lista[i++].ToString());
            saida.idioma = lista[i++].ToString();
            saida.notas_gramatica = lista[i++].ToString();
            saida.nota_cultura = lista[i++].ToString();
            saida.acepcao = int.Parse(lista[i++].ToString());
            saida.Infinitivo = int.Parse(lista[i++].ToString());
            //saida.ChecaOperador(lista[i++].ToString());
            saida.id_conjuga = int.Parse(lista.ElementAt(i++).ToString());
            saida.Genero = lista[i++].ToString();
            saida.Definicao = lista[i++].ToString();          
            return saida;
        }
        
    }
}