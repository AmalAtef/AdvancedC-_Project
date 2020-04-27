using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.DBL;

namespace WindowsFormsApplication1.DAL
{
   static class CountryDAL
    {
        static public List<Country> GetAll()
        {
            List<Country> conts = new List<Country>();
            DataTable dt =DBL.DBL.ExcuteQuery("select * from Country");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                conts.Add(ConvertDataRow(dt.Rows[i]));
            }
            return conts;
        }

        static public Country GetById(int id)
        {
            DataTable dt =DBL.DBL.ExcuteQuery(string.Format("select * from Country where Id= {0} ", id));
            if (dt.Rows.Count > 0)
            {
                return ConvertDataRow(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }

        private static Country ConvertDataRow(DataRow dr)
        {

            int id = Convert.ToInt32(dr["Id"]);
            string name = dr["Name"].ToString();
             return new Country(id, name);

        }

        static public int Add(string Name)
        {
            return Convert.ToInt32(DBL.DBL.ExcuteScaler(string.Format("insert into Country values ('{0}'); select @@Identity", Name)));

        }


        static public int Update(int id, string Name)
        {
            return DBL.DBL.ExcuteNonQuery(string.Format("update Country set Name='{0}' where id ={1} ", Name, id));
        }

        static public int Delete(int id)
        {
            return DBL.DBL.ExcuteNonQuery(string.Format("delete from Country where id ={0}", id));
        }


    }
}
