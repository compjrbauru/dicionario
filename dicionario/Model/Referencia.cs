using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario
{
    class Referencia
    {
        public int Cod { get; set; }
        public string descricao { get; set; }
        public int ano { get; set; }
        public string autor { get; set; }

        public override string ToString()
        {
            string expressao = "Cod=" + Cod + ",descricao='" + descricao + "',ano='" + ano + "',autor='" + autor;
            return expressao;
        }

        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(Cod.ToString());
            val.Add(descricao);
            val.Add(ano.ToString());
            val.Add(autor);
            return val;
        }

        public static List<string> ToListTabela(bool incluiId = false)
        {

            List<string> val = new List<string>();
            if (incluiId)
                val.Add("Cod");
            val.Add("descricao");
            val.Add("ano");
            val.Add("autor");
            return val;
        }
        public static List<Referencia> ConverteObject (List<object[]> entrada)
        {
            List<Referencia> s = new List<Referencia>();
            int lim = entrada.Count;
            Referencia pt = new Referencia();
            object[] po = new object[Referencia.ToListTabela(true).Count];
            for (int i = 0; i < lim; i++)
            {
                po = entrada.ElementAt(i);
                pt = (Referencia)po;
                s.Add(pt);
            }
            return s;
        }
        public static explicit operator Referencia(List<string> lista)
        {
            Referencia novo = new Referencia
            {
                Cod = int.Parse(lista.ElementAt(0)),
                descricao = lista.ElementAt(1),
                ano = int.Parse(lista.ElementAt(2)),
                autor = lista.ElementAt(3)
            };
            return novo;
        }
        public static explicit operator Referencia(object[] lista)
        {
            Referencia novo = new Referencia();
            try {
                novo.Cod = int.Parse(lista[0].ToString());
                novo.descricao = lista[1].ToString();
                novo.ano = int.Parse(lista[2].ToString());
                novo.autor = lista[3].ToString();
            }
            catch (IndexOutOfRangeException) {
                novo.descricao = lista[0].ToString();
                novo.ano = int.Parse(lista[1].ToString());
                novo.autor = lista[2].ToString();
            }
            return novo;
        }
    }
}
