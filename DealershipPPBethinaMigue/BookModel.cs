using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookListPPBethinaMigue
{
    internal class BookModel
    {
        public string _name { get; set; }
        public int _year { get; set; }
        public string _author { get; set; }
        public string _genre { get; set; }
        public int _pages { get; set; }
        public string _description { get; set; }

        public BookModel(string name, int year, string author, string genre, int pages, string description)
        {
            _name = name;
            _year = year;
            _author = author;
            _genre = genre;
            _pages = pages;
            _description = description;
        }
    }
}
