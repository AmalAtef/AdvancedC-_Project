using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DBL
{
    static class DBL
    {

        static SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-JAJHN9O;Initial Catalog=AdvC#Project;Integrated Security=True");

        static public DataTable ExcuteQuery(string SelectStatment)
        {
            SqlCommand sqlcmd = new SqlCommand(SelectStatment, sqlcon);
            SqlDataAdapter adpt = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        static public int ExcuteNonQuery(string NonQueryStatment)
        {
            int result;
            SqlCommand sqlcmd = new SqlCommand(NonQueryStatment, sqlcon);
            sqlcon.Open();
            result = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();
            return result;
        }
        public static object ExcuteScaler(string SelectStatment)
        {
            object result;
            SqlCommand sqlcmd = new SqlCommand(SelectStatment, sqlcon);
            sqlcon.Open();
            result = sqlcmd.ExecuteScalar();
            sqlcon.Close();
            return result;
        }

    }
}
