using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class DVD : Document
    {
        public double Duration { get; set; }
        public DVD(string title, int year, Category category, Author author, double duration) : base(title, year, category, author)
        {
            this.Duration = duration;
            author.AddDocument(this);
        }
    }
}
