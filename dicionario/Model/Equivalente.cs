using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dicionario.Helpers;

namespace dicionario.Model
{
    class Equivalente : Itabelas
    {
        public int origem { get; private set; }
        public int destino { get; private set; }
        public bool heterotonico { get; set; }
        public bool heterossemantico { get; set; }
        public bool heterogenerico { get; set; }

        public static List<string> ToListTabela()
        {
            return new List<string> { "origem", "destino" , "heterotonico", "heterossemantico", "heterogenerico" };
        }

        public List<string> ToListValores()
        {
            List<string> r = new List<string>();
            r.Add(origem.ToString());
            r.Add(destino.ToString());
            r.Add(heterotonico.ToString());
            r.Add(heterossemantico.ToString());
            r.Add(heterogenerico.ToString());
            return r;
        }

        public static List<Equivalente> ConverteObject(List<object[]> entrada){
            List<Equivalente> s = new List<Equivalente>();
            foreach (object data in entrada)
            {
                s.Add((Equivalente)data);
            }
            return s;
        }

        public static explicit operator Equivalente(object[] entrada)
        {
            Equivalente eqv = new Equivalente();
            int i = 0;
            eqv.origem = int.Parse(entrada[i++].ToString());
            eqv.destino = int.Parse(entrada[i++].ToString());
            eqv.heterotonico = Helper.ParseBoolean(entrada[i++].ToString());
            eqv.heterossemantico = Helper.ParseBoolean(entrada[i++].ToString());
            eqv.heterogenerico = Helper.ParseBoolean(entrada[i++].ToString());
            return eqv;
        }
    }
}
