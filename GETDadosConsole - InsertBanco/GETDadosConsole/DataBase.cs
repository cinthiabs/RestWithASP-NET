using System;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GETDadosConsole
{
    class DataBase
    {
        public static int ret;
        private string conn;
        public DataBase()
        {
             this.conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
  
        public static int Exists(string fisrt_name, string email, string username)
        {
            try
            {
                string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                using (SqlConnection sqlconnection = new SqlConnection(conn))
                {
                    DataTable dt = new DataTable();
                    var sql = "PROC_INSERTPERSON '"+ fisrt_name+ "', '"+ email + "', '"+ username + "'";
                    using (SqlCommand command = new SqlCommand(sql, sqlconnection))
                    {
                        sqlconnection.Open();

                        SqlDataAdapter da = new SqlDataAdapter(command);
                        var result = da.Fill(dt);
                       
                        return result;
                        
                    }
                }
            }
            catch
            {
                return -1;
            }
           

        }

    }
}
