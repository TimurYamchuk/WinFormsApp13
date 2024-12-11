using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public Book() { }

        public Book(string title, Author author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return Title + " (Author: " + Author.Name + ")";
        }
    }
}
