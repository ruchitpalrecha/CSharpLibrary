using System;
namespace Library
{
    public class Book
    {

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.borrowed = false;
        }

        public void BorrowBook()
        {
            borrowed = true;
        }

        public void ReturnBook()
        {
            borrowed = false;
        }

        public override string ToString()
        {
            return title + " by " + author;
        }

        private string title;
        private string author;
        private bool borrowed;

        public string Title
        {
            get
            {
                return this.title;
            }
        }

        public bool Borrowed
        {
            get
            {
                return this.borrowed;
            }
        }
    }
}
