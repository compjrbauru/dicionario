using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<string> ToListValores()
        {
            List<string> val = new List<string>();
            val.Add(id.ToString());
            val.Add(descricao);
            val.Add(sigla);
            return val;
        }

        public List<string> ToListTabela()
        {

            List<string> val = new List<string>();
            val.Add("id");
            val.Add("descricao");
            val.Add("sigla");
            return val;
        }

    }
}
