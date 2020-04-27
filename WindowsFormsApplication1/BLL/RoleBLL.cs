using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.BLL
{
    static class RoleBLL
    {

        static public List<Role> GetAll()
        {
            return RoleDAL.GetAll();
        }

        static public Role GetById(int id)
        {
            return RoleDAL.GetById(id);

        }

        static public List<Role> GetByUserId(int userId)
        {
            return RoleDAL.GetByUserId(userId);

        }

    }
}
