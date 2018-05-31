using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dicionario.Model;

namespace dicionario.Model
{
    class Rubrica
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
        public static explicit operator Rubrica (List<string> lista)
        {
            Rubrica rubrica = new Rubrica
            {
                id = int.Parse(lista.ElementAt(0)),
                descricao = lista.ElementAt(1),
                sigla = lista.ElementAt(2)
            };
            return rubrica;
        }
    }
}
