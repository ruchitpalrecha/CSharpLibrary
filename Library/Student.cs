using System;
using System.Collections.Generic;
namespace Library
{
    public class Student
    {

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.books = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            Books.Add(book);
            book.BorrowBook();
        }

        public void ReturnBook(Book book)
        {
            Books.Remove(book);
            book.ReturnBook();
        }

        public override string ToString()
        {
            return Name;
        }

        private string firstName;
        private string lastName;
        private List<Book> books;
        public string Name
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }
        public List<Book> Books
        {
            get
            {
                return this.books;
            }
        }
    }
}
