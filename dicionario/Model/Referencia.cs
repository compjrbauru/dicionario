using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class Referencia
    {
        public int cod { get; set; }
        public string descricao { get; set; }
        public int ano { get; set; }
        public string autor { get; set; }

        public override string ToString()
        {
            string expressao = "cod=" + cod + ",descricao='" + descricao + "',ano='" + ano + "',autor='" + autor;
            return expressao;
        }

        public List<string> ToListValores()
        {
            List<string> val = new List<string>();
            val.Add(cod.ToString());
            val.Add(descricao);
            val.Add(ano.ToString());
            val.Add(autor);
            return val;
        }

        public List<string> ToListTabela()
        {

            List<string> val = new List<string>();
            val.Add("cod");
            val.Add("descricao");
            val.Add("ano");
            val.Add("autor");
            return val;
        }
    }
}
