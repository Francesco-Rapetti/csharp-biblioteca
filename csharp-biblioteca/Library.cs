using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public List<Document> Documents { get; }
        public List<User> Users { get; }
        public List<Loan> Loans { get; }

        public Library(List<Document> documents)
        {
            Documents = documents;
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        public void AddDocument(Document input)
        {
            if (this.Documents.Find(doc => doc.Id == input.Id) == null) Documents.Add(input);
            else Console.WriteLine("Document already exists");
        }

        public void AddUser(User input)
        {
            if (this.Users.Find(user => user.Email == input.Email) == null) Users.Add(input);
            else Console.WriteLine("User already exists");
        }

        public void AddLoan(Loan input)
        {
            if (this.Loans.Find(loan => loan.User.Email == input.User.Email && loan.Document.Id == input.Document.Id && loan.To != "Not returned yet") == null) Loans.Add(input);
            else Console.WriteLine("Loan already exists");
        }

        public Document SearchDocument(string id) => Documents.Find(doc => doc.Id == id) ?? throw new Exception("Document not found");
        public Document SearchDocumentByTitle(string title) => Documents.Find(doc => doc.Title == title) ?? throw new Exception("Document not found");
        public User SearchUser(string email) => Users.Find(user => user.Email == email) ?? throw new Exception("User not found");
        public Loan SearchLoan(string email, string id) => Loans.Find(loan => loan.User.Email == email && loan.Document.Id == id) ?? throw new Exception("Loan not found");
        public List<Loan> SearchUserLoans(string name, string surname) => Loans.FindAll(loan => loan.User.Name == name && loan.User.Surname == surname) ?? throw new Exception("No loans found");
    }
}
