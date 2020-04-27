using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.DAL;
using WindowsFormsApplication1.Entities;
using WindowsFormsApplication1.SL;

namespace WindowsFormsApplication1.BLL
{
    static class CountryBLL
    {
       // [Role(SL.Roletype.admin | SL.Roletype.supervisor|SL.Roletype.instructor)]
        static public List<Country> GetAll()
        {
            return CountryDAL.GetAll();
        }
        [Role(SL.Roletype.admin|SL.Roletype.supervisor)]
        static public Country GetById(int id)
        {
            return CountryDAL.GetById(id);

        }
        [Role(SL.Roletype.admin)]
        static public int Add(string Name)
        {
            return CountryDAL.Add(Name);

        }
        [Role(SL.Roletype.admin)]
        static public int Update(int id, string Name)
        {
            return CountryDAL.Update(id, Name);
        }
        [Role(SL.Roletype.admin)]
        static public int Delete(int id)
        {
            return CountryDAL.Delete(id);
        }


    }
}
