using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.DAL
{
    static class RoleDAL
    {
        static public List<Role> GetAll()
        {

            List<Role> roles = new List<Role>();
            DataTable dt = DBL.DBL.ExcuteQuery("select * from Roles");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                roles.Add(ConvertDataRow(dt.Rows[i]));
            }
            return roles;
        }

        static public Role GetById(int id)
        {

            Role r;
            DataTable dt =DBL.DBL.ExcuteQuery(string.Format("select * from Roles where Id= '{0}' ", id));
            if (dt.Rows.Count > 0)
            {
                r = ConvertDataRow(dt.Rows[0]);
            }
            else
            {
                r = null;
            }
            return r;
        }

        private static Role ConvertDataRow(DataRow dr)
        {

            string name = dr["Name"].ToString();
            return new Role(name);

        }

        public static List<Role> GetByUserId(int UserId)
        {
            List<Role> Roles = new List<Role>();
            DataTable dt = DBL.DBL.ExcuteQuery(string.Format("select Name from Roles as r join users_roles as ur on  r.Id = ur.role_id join Users as u on ur.user_id='{0}'", UserId));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Roles.Add(ConvertDataRow(dt.Rows[i]));
            }

            return Roles;
        }



    }
}
