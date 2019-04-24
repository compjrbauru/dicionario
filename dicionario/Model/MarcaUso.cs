using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dicionario.Model;

namespace dicionario.Model
{
    class MarcaUso
    {

        public int id { get; set; }
        public string descricao { get; set; }
        public string sigla { get; set; }

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
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {

            List<string> val = new List<string>();
            if (incluiId)
                val.Add("id");
            val.Add("descricao");
            val.Add("sigla");
            return val;
        }
        public static List<MarcaUso> ConverteObject(List<object[]> entrada)
        {
            List<MarcaUso> s = new List<MarcaUso>();
            int lim = entrada.Count;
            MarcaUso pt = new MarcaUso();
            object[] po = new object[MarcaUso.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (MarcaUso)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator MarcaUso (List<string> lista)
        {
            MarcaUso rubrica = new MarcaUso
            {
                id = int.Parse(lista.ElementAt(0)),
                descricao = lista.ElementAt(1),
                sigla = lista.ElementAt(2)
            };
            return rubrica;
        }
        public static explicit operator MarcaUso (object[] lista)
        {
            MarcaUso rubrica = new MarcaUso();
            try
            {
                rubrica.id = int.Parse(lista[0].ToString());
                rubrica.descricao = lista[1].ToString();
                rubrica.sigla = lista[2].ToString();
            }
            catch (IndexOutOfRangeException) {
                rubrica.descricao = lista[0].ToString();
                rubrica.sigla = lista[1].ToString();
            }
            return rubrica;
        }
    }
}
