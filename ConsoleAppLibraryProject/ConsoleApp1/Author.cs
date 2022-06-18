using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Id { get; }
        public static int _id;
        public List<Book> books;

        public Author()
        {

        }
        public Author(string name, string surname, int age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
            Id = ++_id;
            books = new List<Book>();
        }
    }
}
