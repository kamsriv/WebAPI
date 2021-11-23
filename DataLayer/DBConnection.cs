using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
//Return the Dapper connection once the connection string is available.
namespace StudentAPI
{
    public class DB
    {
        static IDbConnection _con = null;
        public static string _conStr = "";
        public DB(IConfiguration configuration)
        {
            _conStr = configuration.GetConnectionString("DevDBConstr");
        }
        
        static object obj;
        public static IDbConnection GetConnection()
        {
            lock (obj)
            {
                if (_con is null)
                {
                    try
                    {
                        _con = new SqlConnection(_conStr);
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