using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        public string Name { get; }
        public string Surname { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

        public User(string name, string surname, string email, string password, string phone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
        }
    }
}
