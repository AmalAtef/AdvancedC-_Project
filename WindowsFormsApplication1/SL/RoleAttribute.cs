using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.SL
{
    [Flags]
    enum Roletype
    {
        admin = 1,
        supervisor = 2,
        instructor = 4
    }


    class RoleAttribute : Attribute
    {
        Roletype role;
        public RoleAttribute(Roletype role)
        {
            this.role = role;
        }

        internal Roletype Roletype
        {
            get { return role; }
            set { role = value; }

        }
    }
}
