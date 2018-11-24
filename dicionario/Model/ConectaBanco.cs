using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace dicionario.Model
{
    class ConectaBanco
    {
        private string servidor;
        private string bancoDados;
        private string usuario;
        private string senha;
        private string porta;
        private MySqlConnection conexao;

        public ConectaBanco(string bd = "dicionario", string usr = "root", string pss = "gamesjoker", string svr = "localhost", string porta = "3306")
        {
            string connectionString = "Server=" + svr + ";" + "Port=" + porta + ";Database=" + bd + ";" + "User=" + usr + ";" + "pwd=" + pss + ";";
            conexao = new MySqlConnection(connectionString);
            servidor = svr;
            bancoDados = bd;
            usuario = usr;
            senha = pss;
            this.porta = porta;
        }
        public bool AbreConexao()
        {
            try
            {
                conexao.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                {
                    switch (ex.ErrorCode)
                    {
                        case 0:
                            MessageBox.Show("Falha ao conectar no servidor de dados.");
                            break;
                        case 1045:
                            MessageBox.Show("A combinacao de usuario e senha nao existe. Tente novamente.");
                            break;
                        default:
                            MessageBox.Show("Erro" + ex.Code.ToString() + ex.Message);
                            break;
                    }
                   
                }
                return false;
            }
        }
        public bool FechaConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public MySqlConnection PegaConexao()
        {
            return this.conexao;
        }
    }
    class CRUD{
        private ConectaBanco ControllerBanco = new ConectaBanco("lexdbase","lexdbase","Int3rl3x1c0gr@", "lexdbase.mysql.dbaas.com.br");
        //private ConectaBanco ControllerBanco = new ConectaBanco();
        private string SanitizaQuery(string cmd){
            if (cmd != null)
                if (cmd.Contains("'")){
                    cmd.Replace("'","\\'");
                }
            return cmd;
        }
        private void EnviaComando(string query){
            if (ControllerBanco.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ControllerBanco.PegaConexao());
                cmd.ExecuteNonQuery();
                ControllerBanco.FechaConexao();
            }
        }
        public void InsereLinha(string tabela, List<string> campos, List<string> valores)
        {
            int temp = 0; bool tempb;
            string query = "INSERT INTO " + tabela + " (";
            foreach (string item in campos)
            {
                query += item;
                query += ", ";
            }
            query = query.Remove(query.Length - 2);
            query += ") VALUES(";
            foreach (string item in valores)
            {
                if (int.TryParse(item, out temp)) { //na verdade eu tenho que verificar o Controller e o tipo do campo atual
                    query += item;
                    query += ",";
                }
                else {
                    if (Boolean.TryParse(item, out tempb)){
                        if (tempb)
                            query += "1,";
                        else
                            query += "0,";
                    }
                    else {
                        query += "'";
                        query += SanitizaQuery(item);
                        query += "',";
                    }
                }
            }
            query = query.Remove(query.Length - 1);
            query += ")";
            EnviaComando(query);
        }
        public void UpdateLine(string tabela, List<string> campos, List<string> valores, string filtro = "")
        {
            ///TODO: Analisar a strings contando os dados para que os valores boolean sejam corretamente adaptados para 0 ou 1
            string query = "UPDATE " + tabela + " SET ";
            string temp1, temp2;
            int dummy;
            bool dummyb;
            while (campos.Count > 0)
            {
                temp1 = campos.First();
                temp2 = valores.First();
                query += temp1 + "=";
                 if (int.TryParse(temp2, out dummy)) { //na verdade eu tenho que verificar o Controller e o tipo do campo atual
                    query += temp2;
                }
                else {
                    if (Boolean.TryParse(temp2, out dummyb)){
                        if (dummyb)
                            query += "1";
                        else
                            query += "0";
                    }
                    else {
                        query += "'";
                        query += temp2;
                        query += "'";
                    }
                }
                campos.RemoveAt(0);
                valores.RemoveAt(0);
                if (campos.Count > 0)
                    query += ", ";
            }
            if (filtro != "")
                query += "WHERE " + filtro;
            EnviaComando(query);
        }
        public void ApagaLinha(string tabela, string filtro)
        {
            string query = "DELETE FROM " + tabela + " WHERE " + filtro;
            EnviaComando(query);
        }
        public List<object[]> SelecionarTabela(string tabela, List<string> campos, string filtro = "", string outrosParam = "")
        {
            string query = "SELECT * FROM " + tabela;
            if (filtro != "")
                query += " WHERE " + filtro;
            if (outrosParam != "")
                query += " " + outrosParam;
            List<object[]> resultados = new List<object[]>();
            if (ControllerBanco.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, ControllerBanco.PegaConexao());
                MySqlDataReader dataReader = cmd.ExecuteReader();
                 //REF HERE https://dev.mysql.com/doc/dev/connector-net/6.10/html/T_MySql_Data_MySqlClient_MySqlDataReader.htm
                 if (dataReader.HasRows){
                    object[] colunas = new object[campos.Count];
                    while(dataReader.Read()){
                        dataReader.GetValues(colunas);
                        resultados.Add(RetornaCopia(colunas, campos.Count));
                    }
                 }
                 dataReader.Close();
                 ControllerBanco.FechaConexao();
            }
            return resultados;
        }
        private object[] RetornaCopia (object[] obj, int t)
        {
            object[] o = new object[t];
            obj.CopyTo(o,0);
            return o;
        }
    }
}
