using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Id { get; }
        public static int _id;
        public List<Author> authors;
        public Book()
        {

        }
        public Book(string name, int year) : this()
        {
            Name = name;
            Year = year;
            Id = ++_id;
            authors = new List<Author>();

        }
    }
}
