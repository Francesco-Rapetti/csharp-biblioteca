using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {
        public int Pages { get; }

        public Book(string title, int year, Category category, Author author, int pages) : base(title, year, category, author) 
        {
            this.Pages = pages;
            author.AddDocument(this);
        }
    }
}
