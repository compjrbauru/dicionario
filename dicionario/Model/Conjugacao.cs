using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class Conjugacao
    {
        public int id { get; set; }
        public string preterito { get; set; }
        public string presente { get; set; }
        public string futuro { get; set; }

        public static List<string> ToListTabela()
        {
            List<string> val = new List<string>();
            val.Add("id");
            val.Add("preterito");
            val.Add("presente");
            val.Add("futuro");
            
            return val;
        }
        public List<string> ToListValores()
        {
            List<string> val = new List<string>();
            val.Add(id.ToString());
            val.Add(preterito);
            val.Add(presente);
            val.Add(futuro);
        
            return val;
        }
        public static explicit operator Conjugacao(List<string> lista)
        {
            Conjugacao cnj = new Conjugacao
            {
                id = int.Parse(lista.ElementAt(0)),
                preterito = lista.ElementAt(1),
                presente = lista.ElementAt(2),
                futuro = lista.ElementAt(3)
                
            };
            return cnj;
        }
    }
}
