using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp_myDBAS
{
    class SqlLink
    {
        public SqlConnection conn = new SqlConnection("Data Source=(Local);Pooling=False;Max Pool Size = 1024;Initial Catalog=mycarsystem_DB;Persist Security Info=True;User ID=sa;Password=sa");
        public SqlConnection OpenSql( ) {
            
            conn.Open();
            return conn;
            
        }
        public void CloseSql()
        {

            conn.Close();

        }
    }
}
