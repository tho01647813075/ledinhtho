using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeDinhTho_02
{
    public class DBConnection
    {
        public DBConnection()
        {
        }
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-VE379MA\SQLEXPRESS; Initial Catalog = HR; User Id = sa; Password = 123456";
            return conn;
        }
    }
}
