﻿using System;
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
        public List<Document> Documents { get; }
               

        public Author(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Documents = new List<Document>();
        }

        public void AddDocument(Document book) => Documents.Add(book);
        public string GetListDocuments() => string.Join(", ", Documents);
    }
    }
}
