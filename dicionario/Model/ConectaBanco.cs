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

        public ConectaBanco(string bd, string usr, string pss, string svr = "localhost", string porta = "3306")
        {
            PreparaConexao(bd, usr, pss, svr, porta);
            servidor = svr;
            bancoDados = bd;
            usuario = usr;
            senha = pss;
            this.porta = porta;
        }
        private void PreparaConexao(string bd, string usr, string pss, string svr = "localhost", string port = "3306")
        {
            string connectionString = "Server=" + svr + ";" + "Port=" + port + ";Database=" + bd + ";" + "User=" + usr + ";" + "pwd=" + pss + ";";
            conexao = new MySqlConnection(connectionString);
        }
        private bool AbreConexao()
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
        private bool FechaConexao()
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
                        query += item;
                        query += "',";
                    }
                }
            }
            query = query.Remove(query.Length - 1);
            query += ")";
            if (this.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }
        public void UpdateLine(string tabela, List<string> campos, List<string> valores, string filtro = "")
        {
            ///TODO: Analisar a strings contando os dados para que os valores boolean sejam corretamente adaptados para 0 ou 1
            string query = "UPDATE " + tabela + " SET ";
            string temp1, temp2;
            while (campos.Count > 0)
            {
                temp1 = campos.First();
                temp2 = valores.First();
                query += temp1 + "=" + "'" + temp2 + "'";
                campos.RemoveAt(0);
                valores.RemoveAt(0);
                if (campos.Count > 0)
                    query += ", ";
            }
            if (filtro != "")
                query += "WHERE " + filtro;
            if (this.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = conexao;
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }
        public void ApagaLinha(string tabela, string filtro)
        {
            string query = "DELETE FROM " + tabela + " WHERE " + filtro;
            if (this.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.ExecuteNonQuery();
                this.FechaConexao();
            }
        }
        public List<string>[] Select(string tabela, List<string> campos, string filtro = "", string outrosParam = "")
        {
            string query = "SELECT * FROM " + tabela;
            int qtReg = campos.Count;
            if (filtro != "")
                query += " WHERE " + filtro;
            if (outrosParam != "")
                query += " " + outrosParam;
            List<string>[] list = new List<string>[qtReg];
            for (int i = 0; i < qtReg; i++)
            {
                list[i] = new List<string>();
            }
            if (this.AbreConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                switch (tabela)
                {
                    case "categoriagram":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id"] + "");
                            list[1].Add(dataReader["Descricao"] + "");
                            list[2].Add(dataReader["sigla"] + "");
                            list[3].Add(dataReader["definicao"] + "");
                        }
                    break;
                    case "classegram":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id"] + "");
                            list[1].Add(dataReader["Descricao"] + "");
                            list[2].Add(dataReader["sigla"] + "");
                        }
                        break;
                    case "palavra":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id"] + "");
                            list[1].Add(dataReader["Lema"] + "");
                            list[2].Add(dataReader["Id_catGram"] + "");
                            list[3].Add(dataReader["Id_classeGram"] + "");
                            list[4].Add(dataReader["Idioma"] + "");
                            list[5].Add(dataReader["Rubrica"] + "");
                            list[6].Add(dataReader["heterogenerico"] + "");
                            list[7].Add(dataReader["heterotonico"] + "");
                            list[8].Add(dataReader["equivalente"] + "");
                            list[9].Add(dataReader["referencia_verbete"] + "");
                            list[10].Add(dataReader["referencia_exemplo"] + "");
                            list[11].Add(dataReader["notas_gramatica"] + "");
                            list[12].Add(dataReader["notas_cultura"] + "");
                            list[13].Add(dataReader["acepcao"] + "");
                            list[14].Add(dataReader["heterossemantico"] + "");
                            list[15].Add(dataReader["referencia_exemplo_tr"] + "");
                            list[16].Add(dataReader["Infinitivo"] + "");
                            list[17].Add(dataReader["equivalente_pluriv"] + "");
                        }
                        break;
                    case "rubrica":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["id"] + "");
                            list[1].Add(dataReader["Descricao"] + "");
                            list[2].Add(dataReader["sigla"] + "");
                        }
                        break;
                    case "referencias":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["Cod"] + "");
                            list[1].Add(dataReader["Descricao"] + "");
                            list[2].Add(dataReader["Ano"] + "");
                            list[3].Add(dataReader["Autor"] + "");
                        }
                        break;
                    case "usr":
                        while (dataReader.Read())
                        {
                            list[0].Add(dataReader["usr"] + "");
                            list[1].Add(dataReader["pass"] + "");
                            list[2].Add(dataReader["nivel_permissao"] + "");
                            list[3].Add(dataReader["email"] + "");
                            list[4].Add(dataReader["nome"] + "");
                            list[5].Add(dataReader["contato"] + "");
                            list[6].Add(dataReader["rede_social"] + "");
                            list[7].Add(dataReader["cpf"] + "");
                            list[8].Add(dataReader["telefone"] + "");
                        }
                        break;
                    default:
                        throw new Exception("Tabela não tratada no programa!");
                    
                }
                dataReader.Close();
                this.FechaConexao();
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
