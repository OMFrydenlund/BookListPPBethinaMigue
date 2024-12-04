using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListPPBethinaMigue
{
    internal class BookModel
    {
        public string _title { get; set; }
        public int _year { get; set; }
        public string _author { get; set; }
        public string _genre { get; set; }
        public int _pages { get; set; }
        public string _description { get; set; }

        public BookModel()
        {
            
        }
        public BookModel(string name, int year, string author, string genre, int pages, string description)
        {
            _title = name;
            _year = year;
            _author = author;
            _genre = genre;
            _pages = pages;
            _description = description;
        }

        public void GetAllBookInfo(BookModel book)
        {
            book.GetTitle();
            book.GetYear();
            book.GetAuthor();
            book.GetGenre();
            book.GetPages();
            book.GetDescription();
        }

        public void PrintBookInfo()
        {
            Console.WriteLine("************************");
            Console.Write($"Title: {_title}, by {_author}\nPublished: {_year}, {_genre}\n{_pages} pages\n\n{_description}\n\n");            
        }

        void GetTitle()
        {
            Console.Write("What is the title of your book: ");
            string input = Console.ReadLine();
            _title = input;
        }
        void GetYear()
        {
            Console.Write("Published when: ");
            int input = int.Parse( Console.ReadLine());
            _year = input;
        }
        void GetAuthor()
        {
            Console.Write("Who is the author: ");
            string input = Console.ReadLine();
            _author = input;
        }

        void GetGenre()
        {
            Console.Write("What genre: ");
            string input = Console.ReadLine();
            _genre = input;
        }

        void GetPages()
        {
            Console.Write("How many pages: ");
            int input = int.Parse(Console.ReadLine());
            _pages = input;
        }

        void GetDescription()
        {
            Console.Write("Give a short description of your book: ");
            string input = Console.ReadLine();
            _description = input;
        }
    }
}