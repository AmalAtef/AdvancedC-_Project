using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entities
{
    public class Role
    {
        int id;
        string name;
        List<User> users;
        public int Id { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public List<User> Cities { get; set; }

        public Role(string _name)
        {
            name = _name;
        }
        public Role(int _id, string _name, List<User> _users)
        {
            id = _id;
            name = _name;
            users = _users;
        }
    }
}
