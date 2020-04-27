using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.DAL
{
    static class UserDAL
    {
        static public List<User> GetAll()
        {

            List<User> roles = new List<User>();
            DataTable dt = DBL.DBL.ExcuteQuery("select * from Users");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                roles.Add(ConvertDataRow(dt.Rows[i]));
            }
            return roles;
        }

        static public User GetById(int id)
        {

            User u;
            DataTable dt = DBL.DBL.ExcuteQuery(string.Format("select * from Users where Id= {0} ", id));
            if (dt.Rows.Count > 0)
            {
                u = ConvertDataRow(dt.Rows[0]);
            }
            else
            {
                u = null;
            }
            return u;
        }

        private static User ConvertDataRow(DataRow dr)
        {

            int id = Convert.ToInt32(dr["Id"]);
            string email = dr["Email"].ToString();
            string password= dr["Password"].ToString();
            List<Role> roles = RoleDAL.GetByUserId(id);
            return new User(id, email, password, roles);

        }

        public static List<User> GetByRoleId(int RoleId)
        {
            List<User> Users = new List<User>();
            DataTable dt = DBL.DBL.ExcuteQuery(string.Format("select u.Id as Id, Email ,Password  from Users as u join users_roles as ur on  u.Id =ur.user_id join Roles as r on ur.role_id='{0}'", RoleId));

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users.Add(ConvertDataRow(dt.Rows[i]));
            }

            return Users;
        }

        public static int GetByEmailAndPassword (string email,string password)
        {
            DataTable dt = DBL.DBL.ExcuteQuery(string.Format("select Id from Users where Email = '{0}' and Password = '{1}'", email,password));
            if (dt.Rows.Count == 0) return 0;

            int UserId= Convert.ToInt32(dt.Rows[0]["Id"]);
            return UserId;

        }

        static public int Add(string email, string password)
        {
            return Convert.ToInt32(DBL.DBL.ExcuteScaler(string.Format("insert into Users values ('{0}',{1});select @@Identity", email, password)));

        }

    }
}
