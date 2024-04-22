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
        public List<Loan> Loans { get; }

        public User(string name, string surname, string email, string password, string phone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Loans = new List<Loan>();
        }

        public override string ToString() => $"{this.Name} {this.Surname} - {this.Email}";
        public void AddLoan(Loan input)
        {
            if (this.Loans.Find(loan => loan.User.Email == input.User.Email && loan.Document.Id == input.Document.Id && loan.To != "Not returned yet") == null) this.Loans.Add(input);
            else Console.WriteLine("Loan already exists");
        }
    }
}
