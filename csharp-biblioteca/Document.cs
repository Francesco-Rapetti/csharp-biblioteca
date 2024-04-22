using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        public string Id { get; }
        public string Title { get; }
        public int Year { get; }
        public Category Category { get; set; }
        public char Shelf { get; }
        public Author Author { get; }

        public Document(string title, int year, Category category, Author author)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Title = title;
            this.Year = year;
            this.Category = category;
            this.Author = author;
            this.Shelf = Author.Surname[0];
        }

        public override string ToString() => $"TITLE: {this.Title}\nYEAR: {this.Year}\nCATEGORY: {this.Category}\nSHELF: {this.Shelf}\nAUTHOR: {this.Author}\n";
    }



    public enum Category
    {
        HISTORY,
        MATHEMATICS,
        ECONOMY,
        FANTASY,
        OTHER
    }
}
