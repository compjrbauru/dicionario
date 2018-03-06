using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicionario.Model
{
    class Usuario
    {
        public Usuario() { }
        public string usr { get; set; }
        public string pass { get; set; }
        public string permissao { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string contato { get; set; }
        public string rsocial { get; set; }
        public string cpf { get; set; }
        public string tel { get; set; }

        public override string ToString()
        {
            string expressao = "usr=" + usr + ",pass='" + pass + "',nivel_permissao='" + permissao + "',email='" + email + "',nome='" + nome + "',contato='" + contato + "',rede_social='" + rsocial + "',cpf='" + cpf + "',telefone='" + tel;
            return expressao;
        }

        public List<string> ToListTabela(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
            val.Add("usr");
            val.Add("pass");
            val.Add("nivel_permissao");
            val.Add("email");
            val.Add("nome");
            val.Add("contato");
            val.Add("rede_social");
            val.Add("cpf");
            val.Add("telefone");
            return val;
        }
        public List<string> ToListValores(bool incluiId = false)
        {
            List<string> val = new List<string>();
            if (incluiId)
                val.Add(usr.ToString());
            val.Add(pass);
            val.Add(permissao);
            val.Add(email);
            val.Add(nome);
            val.Add(contato);
            val.Add(rsocial);
            val.Add(cpf);
            val.Add(tel);
            return val;
        }
    }
}
