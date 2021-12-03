using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
//Return the Dapper connection once the connection string is available.
namespace StudentAPI
{
    public class DB
    {
        static IDbConnection _con = null;
        public static string ConStr = "";
        private DB(){}
        static object obj = new object();
        public static IDbConnection GetConnection()
        {
            lock (obj)
            {
                if (_con is null)
                {
                    try
                    {
                        _con = new SqlConnection(ConStr);
                        _con.Open();
                    }
                    catch (SqlException ex)
                    {
                        throw new StudentAPIException(ex.Message,ex.InnerException);
                    }
                }
            }
            return _con;
        }
        public static void CloseConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}