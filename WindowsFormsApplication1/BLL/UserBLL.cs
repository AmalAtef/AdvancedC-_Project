using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.BLL
{
   static class UserBLL
    {


        static public List<User> GetAll()
        {
            return UserDAL.GetAll();
        }

        static public User GetById(int id)
        {
            return UserDAL.GetById(id);

        }

        static public List<User> GetByRoleId(int roleId)
        {
            return UserDAL.GetByRoleId(roleId);

        }

        public static int GetByEmailAndPassword(string email, string password)
        {
            return UserDAL.GetByEmailAndPassword(email,password);
        }
        static public int Add(string email, string password)
        {
            return UserDAL.Add(email,password);

        }

    }
}
