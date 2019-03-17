using System;

namespace Library
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Library lib = new Library();
            MainMenu(lib);


            Book dracula = new Book("Dracula", "Bram Stoker");
            lib.AddBook(dracula);
            lib.AddBook(new Book("Harry Potter", "J.K. Rowling"));
            Student johnDoe = new Student("John", "Doe");
            lib.AddStudent(johnDoe);
            lib.BorrowBook(johnDoe, dracula);
        }

        public static void MainMenu(Library lib)
        {
            Console.WriteLine("-----Welcome to the Library!-----");
            Console.WriteLine("   Choose one of the following:  ");
            Console.WriteLine("1 - Show Available Books");
            Console.WriteLine("2 - Show Students");
            Console.WriteLine("3 - Borrow a Book");
            Console.WriteLine("4 - Return a Book");
            Console.WriteLine("5 - Add a new Student");
            Console.WriteLine("6 - Remove a Student");
            Console.WriteLine("7 - Add a new Book");
            Console.WriteLine("8 - Remove a Book");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("---------------------------------");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ShowAvailableBooks(lib);
                        break;
                    case 2:
                        ShowStudents(lib);
                        break;
                    case 3:
                        BorrowBookMenu(lib);
                        break;
                    case 4:
                        ReturnBookMenu(lib);
                        break;
                    case 5:
                        AddStudentMenu(lib);
                        break;
                    case 6:
                        RemoveStudentMenu(lib);
                        break;
                    case 7:
                        AddBookMenu(lib);
                        break;
                    case 0:
                        Environment.Exit(1);
                        return;
                    default:
                        Console.WriteLine("Invalid Option. Try Again");
                        MainMenu(lib);
                        break;
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input! Try Again");
            }
            finally
            {
                MainMenu(lib);
            }
        }

        public static void ShowAvailableBooks(Library lib)
        {
            foreach(Book book in lib.GetAvailableBooks())
            {
                Console.WriteLine(book);
            }
            MainMenu(lib);
        }

        public static void ShowStudents(Library lib)
        {
            foreach(Student student in lib.Students)
            {
                Console.WriteLine(student);
            }
            MainMenu(lib);
        }

        public static void BorrowBookMenu(Library lib)
        {
            try
            {
                Console.WriteLine("What is your name?");
                Student student = lib.GetStudent(Console.ReadLine());
                Console.WriteLine("What is the book name?");
                Book book = lib.GetBook(Console.ReadLine());
                lib.BorrowBook(student, book);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                MainMenu(lib);
            }
        }

        public static void ReturnBookMenu(Library lib)
        {
            try
            {
                Console.WriteLine("What is your name?");
                Student student = lib.GetStudent(Console.ReadLine());
                Console.WriteLine("What is the book name?");
                Book book = lib.GetBook(Console.ReadLine());
                lib.ReturnBook(student, book);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                MainMenu(lib);
            }
        }

        public static void AddStudentMenu(Library lib)
        {
            try
            {
                Console.WriteLine("What is your name?");
                string fullName = Console.ReadLine();
                int index = fullName.IndexOf(' ');
                string firstName = fullName.Substring(0, index);
                string lastName = fullName.Substring(index + 1);
                lib.AddStudent(new Student(firstName, lastName));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                MainMenu(lib);
            }
        }

        public static void RemoveStudentMenu(Library lib)
        {
            try
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                lib.RemoveStudent(lib.GetStudent(name));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                MainMenu(lib);
            }
        }

        public static void AddBookMenu(Library lib)
        {
            try
            {
                Console.WriteLine("What is the title?");
                string title = Console.ReadLine();
                Console.WriteLine("Who is the author?");
                string author = Console.ReadLine();
                lib.AddBook(new Book(title, author));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
