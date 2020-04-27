using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Entities
{
    public class User
    {
        int id;
        string email;
        string password;
        List<Role> roles;
            public int Id {
            get { return id; }
            set { id = value; }
        }
            public string Email { get { return email; }
            set { email = value; } }
            public string Password {
            get { return password; }
            set { password = value; }
        }
            public List<Role> Roles { get; set; }
        public User(int _id, string _email, string _password)
        {

            id = _id;
            email = _email;
            password = _password;
        }
        public User(int _id, string _email,string _password,List<Role> _roles)
        {
            id = _id;
            email = _email;
            password = _password;
            roles = _roles;
        }

    }
}
