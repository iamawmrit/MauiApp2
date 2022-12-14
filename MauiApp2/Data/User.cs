using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Role Role { get; set; }
    }
    public enum Role
    {
        User,
        Admin
    }
}
