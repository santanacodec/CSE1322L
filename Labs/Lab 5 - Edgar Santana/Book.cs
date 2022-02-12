using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5___Edgar_Santana
{
    class Book : Item
    {
        private long isbn_number;
        private string author;

        public Book() { }

        public Book(string title, long isbn_number, string author) : base(title)
        {
            this.isbn_number = isbn_number;
            this.author = author;
        }

        public long getIsbn_Number()
        {
            return isbn_number;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setIsbnNumber(long isbn_number)
        {
            this.isbn_number = isbn_number;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public override string getListing()
        {
            return "Book Name- " + getTitle() + "\nAuthor- " + author + "\nISBN #- " + isbn_number;
        }
    }
}
