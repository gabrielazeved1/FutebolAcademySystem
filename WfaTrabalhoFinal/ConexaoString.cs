using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WfaTrabalhoFinal
{
    class ConexaoString
    {
        string serverName = "localhost";
        string port = "5432";
        string userName = "postgres";
        string password = "5252";
        string dataBaseName = "bdEscolinha";

        /*
        public string StrConexao => String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3};" +
                "Database = {4};", serverName, port, userName, password, dataBaseName);
        */
        public string Conectar()
        {
            var connString = String.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3};" +
                "Database = {4};", serverName, port, userName, password, dataBaseName);
            return connString;
        }



    }
}
