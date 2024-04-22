using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Loan
    {
        public User User { get; }
        public Document Document { get; }
        public string From { get; }
        public string To { get; private set; }

        public Loan(User user, Document document)
        {
            this.User = user;
            this.Document = document;
            this.From = DateTime.Now.ToString();
            this.To = "Not returned yet";
            User.AddLoan(this);
        }

        public void Return() => this.To = DateTime.Now.ToString();

        public override string ToString() => $"USER: {this.User}\nDOCUMENT: \n\t{FormatDocumentInfo(this.Document)}FROM: {this.From}\nTO: {this.To}\n";

        private string FormatDocumentInfo(Document document)
        {
            string output = document.ToString();
            List<string> list = output.Split('\n').ToList();
            output = string.Join("\n\t", list);
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
