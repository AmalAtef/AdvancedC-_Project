using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.BLL;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.SL
{
    class RoleSL
    {

        static public List<Role> GetAll()
        {
            return RoleBLL.GetAll();
        }

        static public Role GetById(int id)
        {
            return RoleBLL.GetById(id);

        }

        static public List<Role> GetByUserId(int userId)
        {
            return RoleBLL.GetByUserId(userId);

        }
    }
}
