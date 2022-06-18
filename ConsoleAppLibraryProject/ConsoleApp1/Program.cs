using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library libray = new Library("Library");
            while (true)
            {
                Console.WriteLine("1.Add a staff member to the library ");
                Console.WriteLine("2.Add an author ");
                Console.WriteLine("3.Add a book to the library ");
                Console.WriteLine("4.Delete a library employee ");
                Console.WriteLine("5.Delete a book from the library ");
                Console.WriteLine ("6.Look at the author's books");

                string numm = Console.ReadLine();
                bool isInt = int.TryParse(numm, out int menu);
                switch (menu)
                {
                    case 1:
                        #region addemploye
                        Console.WriteLine("Employee's name");
                        string ename = Console.ReadLine();
                        Console.WriteLine("The employee's last surname");
                        string esname = Console.ReadLine();
                        AGE:
                        Console.WriteLine("Employee's Age");
                        string eage = Console.ReadLine();
                        bool isAge = int.TryParse(eage, out int age);
                        if (!isAge)
                        {
                            Console.WriteLine("Incorrectly entered, please enter correctly");
                            goto AGE;
                        }
                        Employe employe = new Employe(ename, esname, age);
                        libray.employes.Add(employe);
                        Console.WriteLine($" An employee {ename} named this has been added ");
                        break;
                    #endregion
                    case 2:
                        #region addauthor
                        Console.WriteLine("Author's name");
                        string mname = Console.ReadLine();
                        Console.WriteLine("Author's surname");
                        string msname = Console.ReadLine();
                        AGEE:
                        Console.WriteLine("Age of the author");
                        string mage = Console.ReadLine();
                        bool ismAge = int.TryParse(mage, out int _mage);
                        if (!ismAge)
                        {
                            Console.WriteLine("Incorrectly entered, please enter correctly");
                            goto AGEE;
                        }
                        Author author = new Author(mname, msname, _mage);
                        libray.authors.Add(author);
                        Console.WriteLine($" An author by {mname} name has been added ");
                        break;
                    #endregion
                    case 3:
                        #region addbook
                        Console.WriteLine("Book name");
                        string kname = Console.ReadLine();
                        year:
                        Console.WriteLine("Book release year");
                        string kyear = Console.ReadLine();

                        bool isYear = int.TryParse(kyear, out int year);
                        if (!isYear)
                        {
                            Console.WriteLine("Incorrectly entered, please enter correctly");
                            goto year;

                        }
                        Book book = new Book(kname, year);
                        foreach (var item in libray.authors)
                        {
                            Console.WriteLine($"ID--{item.Id}  Name--{item.Name}");
                        }
                        
                        Iddd:
                        Console.WriteLine("Enter an ID to select the author or authors");
                        string mid = Console.ReadLine();
                        string[] mid2 = mid.Split(",");
                        foreach (var item in mid2)
                        {
                            bool isMid = int.TryParse(item, out int midd2);
                            if (!isMid)
                            {
                                Console.WriteLine("Incorrectly entered, please enter correctly");
                                goto Iddd;
                            }
                            foreach (var item1 in libray.authors)
                            {
                                if (item1.Id==midd2)
                                {
                                    book.authors.Add(item1);
                                    
                                    item1.books.Add(book);
                                    
                                }
                            }
                            
                        }
                        libray.books.Add(book);
                        Console.WriteLine($" A book {kname}  was created");

                        break;
                    #endregion
                    case 4:
                        #region deletemploye
                        foreach (var item in libray.employes)
                        {
                            Console.WriteLine($"ID--{item.Id}  Name--{item.Name}");
                        }
                        idd:
                        Console.WriteLine("Enter the ID of the employee you want to delete");
                        string did = Console.ReadLine();
                        bool isid = int.TryParse(did, out int _id);
                        if (!isid)
                        {
                            Console.WriteLine("Incorrectly entered, please enter correctly");
                            goto idd;
                        }
                        foreach (var item in libray.employes)
                        {
                            if (item.Id == _id)
                            {
                                libray.employes.Remove(item);
                                Console.WriteLine($" {item.Name} was deleted");
                                break;
                            }
                        }
                        break;
                    #endregion
                    case 5:
                        #region deletebook
                        foreach (var item in libray.books)
                        {
                            Console.WriteLine($"ID --{item.Id}  Name--{item.Name}");
                        }
                        iddd:
                        Console.WriteLine("Enter the ID of the book you want to delete");
                        string kid = Console.ReadLine();
                        bool isidk = int.TryParse(kid, out int __id);
                        if (!isidk)
                        {
                            Console.WriteLine("Incorrectly entered, please enter correctly");
                            goto iddd;
                        }
                        foreach (var item in libray.books)
                        {
                           
                            if (item.Id == __id)
                            {
                                foreach (var item1 in libray.authors)
                                {
                                    item1.books.Remove(item);
                        }
                                libray.books.Remove(item);
                                
                                Console.WriteLine($"{item.Name} was deleted");
                                break;
                            }
                        }
                       
                        break;
                    #endregion
                    case 6:
                        #region seebooks
                        foreach (var item in libray.authors)
                        {
                            Console.WriteLine($"{item.Id}  {item.Name}");
                        }
                        Console.WriteLine("Enter the ID  of the author you want to see his books");
                        string middd = Console.ReadLine();
                        int _mid = int.Parse(middd);
                        foreach (var item in libray.authors)
                        {
                            if (item.Id==_mid)
                            {
                                foreach (var item1 in item.books)
                                {
                                    Console.WriteLine(item1.Name);
                                }
                            }
                        }
                        break;
                    #endregion
                    default:
                        break;
                }
            }
        }
    }
}
