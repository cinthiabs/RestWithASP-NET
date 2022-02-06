using System;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GETDadosConsole
{
    class DataBase
    {
        private string conn;
        public DataBase()
        {
            this.conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
        public static void SalvaDados(Person person)
        {
            string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            DataBase db = new DataBase();
            string sql = "INSERT INTO Person ";
            sql += "(first_name,";
            sql += "email,";
            sql += "username, ";
            sql += "VALUES (";
            sql += "'" +person.first_name;
            sql += ",'" + person.email;
            sql += ",'" + person.username;
            sql += ")";
                           
            using (SqlConnection sqlconnection = new SqlConnection(conn))
            {
                try
                {
                    var iinsert = sqlconnection.Execute(sql, person);
                }
                catch(Exception e)
                {
                    
                    throw new ArgumentException(e.Message);
                }
            }
        }
    }
}
