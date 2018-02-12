using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army_Vechical_Entry
{
    public class SqlHelper
    {
        SqlConnection con;
        public SqlHelper(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }
        public bool IsConnect
        {
            get
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                return true;
            }
        }

        private static string _global_Connection_String = "";

        public static string Global_Connection_String
        {
            get { return _global_Connection_String; }
            set { _global_Connection_String = value; }
        }

        private static string _global_Location_String = "";

        public static string Global_Location_String
        {
            get { return _global_Location_String; }
            set { _global_Location_String = value; }
        }
    }
}
