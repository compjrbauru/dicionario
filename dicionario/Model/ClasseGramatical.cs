using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class ClasseGramatical
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }
        public string Definicao { get; set; }

        public override string ToString()
        {
            string expressao = "id=" + id + ",descricao='" + descricao + "',sigla='" + sigla;
            return expressao;
        }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(id.ToString());
            val.Add(descricao);
            val.Add(sigla);
            val.Add(Definicao);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {

            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("descricao");
            val.Add("sigla");
            val.Add("Definicao");
            return val;
        }
        public static List<ClasseGramatical> ConverteObject(List<object[]> entrada) {
            List<ClasseGramatical> s = new List<ClasseGramatical>();
            int lim = entrada.Count;
            ClasseGramatical pt = new ClasseGramatical();
            object[] po = new object[ClasseGramatical.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (ClasseGramatical)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator ClasseGramatical(List<string> lista)
        {
            ClasseGramatical cl = new ClasseGramatical
            {
                id = int.Parse(lista.ElementAt(0)),
                descricao = lista.ElementAt(1),
                sigla = lista.ElementAt(2),
                Definicao = lista.ElementAt(3)
            };
            return cl;
        }
        public static explicit operator ClasseGramatical(object[] lista)
        {
            ClasseGramatical cl = new ClasseGramatical();
            try
            {
                cl.id = int.Parse(lista[0].ToString());
                cl.descricao = lista[1].ToString();
                cl.sigla = lista[2].ToString();
                cl.Definicao = lista[3].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                cl.descricao = lista[0].ToString();
                cl.sigla = lista[1].ToString();
                cl.Definicao = lista[2].ToString();

            }
            return cl;
        }
    }
}
