using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Author
    {
        public string Name { get; }
        public string Surname { get; }
        public List<Book> WrittenBooks { get; }
               

        public Author(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.WrittenBooks = new List<Book>();
        }

        public void AddWrittenBook(Book book) => WrittenBooks.Add(book);
        public string GetListWrittenBooks() => string.Join(", ", WrittenBooks);
    }
    }
}
