using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.BLL;
using WindowsFormsApplication1.Entities;

namespace WindowsFormsApplication1.SL
{
    class CountrySL
    {
        public static List<Country> GetAll()
        {
            return CountryBLL.GetAll();
        }
        public static Country GetById(int id)
        {
            Country country = null;

           //User
            User user = Form1.currentUser;
            //Get User's Roles
            List<Role> roles = RoleBLL.GetByUserId(user.Id);


            //Get Type
            Type type = typeof(CountryBLL);
            //Get Function
            MethodInfo method = type.GetMethod("GetById");

            //Get Attribute
            RoleAttribute attribute = method.GetCustomAttribute<RoleAttribute>();

            //Get Function Role
            Roletype functionRole = attribute.Roletype;

            //if user allowed ===> return real country
            bool flage = false;
            foreach (var item in roles)
            {
                var r = (Roletype)Enum.Parse(typeof(Roletype), item.Name, true);
                if (functionRole.HasFlag((Roletype)Enum.Parse(typeof(Roletype), item.Name, true)))
                    flage = true;
            }
            if (flage)
                country = CountryBLL.GetById(id);

            return country;
        }
        static public int Add(string Name)
        {

             int Id= 0;
             User user = Form1.currentUser;
            //Get User's Roles
            List< Role > roles= RoleBLL.GetByUserId(user.Id);

            ////Get Type
            Type type = typeof(CountryBLL);
            //Get Function
            MethodInfo method = type.GetMethod("Add");

            //Get Attribute
            RoleAttribute attribute = method.GetCustomAttribute<RoleAttribute>();

            //Get Function Role
            Roletype functionRole = attribute.Roletype;

            //if user allowed ===> return real Id of new country
            bool flage = false;
            foreach (var item in roles)
            {
                var r = (Roletype)Enum.Parse(typeof(Roletype), item.Name, true);
                if (functionRole.HasFlag((Roletype)Enum.Parse(typeof(Roletype), item.Name, true)))
                    flage = true;
            }
            if (flage)
                    Id = CountryBLL.Add(Name);

            return Id;

        }
        static public int Delete(int id)
        {


            int IdDeleted = 0;
            User user = Form1.currentUser;
            //Get User's Roles
            List<Role> roles = RoleBLL.GetByUserId(user.Id);

            ////Get Type
            Type type = typeof(CountryBLL);
            //Get Function
            MethodInfo method = type.GetMethod("Delete");

            //Get Attribute
            RoleAttribute attribute = method.GetCustomAttribute<RoleAttribute>();

            //Get Function Role
            Roletype functionRole = attribute.Roletype;

            //if user allowed ===> return real Id of deleted country
            bool flage = false;
            foreach (var item in roles)
            {
                var r = (Roletype)Enum.Parse(typeof(Roletype), item.Name, true);
                if (functionRole.HasFlag((Roletype)Enum.Parse(typeof(Roletype), item.Name, true)))
                    flage = true;
            }
            if (flage)
                IdDeleted = CountryBLL.Delete(id);

            return IdDeleted;
        }
    }
}
