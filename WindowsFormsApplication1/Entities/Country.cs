using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entities
{
    public class Country
    {

        int id;
        string name;
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Country(int _id, string _name)
        {
            id = _id;
            name = _name;
        }

    }
}
