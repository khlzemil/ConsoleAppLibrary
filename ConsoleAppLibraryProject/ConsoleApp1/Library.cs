using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library
    {
        public string Name { get; set; }
        public List<Employe> employes;
        public List<Book> books;
        public List<Author> authors;

        public Library(string name)
        {
            Name = name;
            employes = new List<Employe>();
            books = new List<Book>();
            authors = new List<Author>();

        }
    }
}
