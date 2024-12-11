using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13
{
    public class Author
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public Author() { }

        public Author(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
