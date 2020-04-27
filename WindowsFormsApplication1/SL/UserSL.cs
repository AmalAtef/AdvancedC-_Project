using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.BLL;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.SL
{
    class UserSL
    {

        static public List<User> GetAll()
        {
            return UserBLL.GetAll();
        }

        static public User GetById(int id)
        {
            return UserBLL.GetById(id);

        }

        static public List<User> GetBy(int roleId)
        {
            return UserBLL.GetByRoleId(roleId);

        }

        public static int GetByEmailAndPassword(string email, string password)
        {
            return UserBLL.GetByEmailAndPassword(email, password);
        }

        static public int Add(string email, string password)
        {
            return UserBLL.Add(email, password);

        }



    }
}
