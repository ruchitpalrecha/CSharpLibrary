using System;
using System.Collections.Generic;
namespace Library
{
    public class Library
    {

        public Library()
        {
            books = new List<Book>();
            students = new List<Student>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void AddStudent(Student student)
        {
            if(student.Equals(null))
            {
                throw new ArgumentNullException("That is not a valid student");
            }
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void BorrowBook(Student student, Book book)
        {
            if (students.Contains(student) && books.Contains(book))
            {
                student.BorrowBook(book);
            }
            else if (!students.Contains(student))
            {
                Console.WriteLine("Student " + student.Name + "is not in our list");
            }
            else
            {
                Console.WriteLine("Book does not exist at our library");
            }
        }

        public void ReturnBook(Student student, Book book)
        {
            if (students.Contains(student) && books.Contains(book))
            {
                student.ReturnBook(book);
            }
            else if (!students.Contains(student))
            {
                Console.WriteLine("Student " + student.Name + "is not in our list");
            }
            else
            {
                Console.WriteLine("Book does not exist at our library");
            }
        }

        public Student GetStudent(string name)
        {
            foreach (Student student in students)
            {
                if (student.Name == name)
                {
                    return student;
                }
            }

            throw new ArgumentException("That is not a valid student.");
        }

        public Book GetBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }

            throw new ArgumentException("That is not a valid book.");
        }

        public List<Book> GetAvailableBooks()
        {
            List<Book> available = new List<Book>();
            foreach(Book book in books)
            {
                if(!book.Borrowed)
                {
                    available.Add(book);
                }
            }
            return available;
        }

        private List<Book> books;
        private List<Student> students;
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value)) {
                    throw new ArgumentException("New name was null or empty.");
                }

                this.name = value;
            }
        }
        public List<Book> Books
        {
            get
            {
                return this.books;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
        }
    }
}
