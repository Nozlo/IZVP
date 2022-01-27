using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_3.Classe_folder
{
    class Book : Printing
    {
        private string authors;
        private string publisher;
        private int pages;

        public Book() { }

        public Book(string _name, int _year, int _numberOfCopiesInLibrary, int _numberOfCopiesTakenByReaders, string _authors, string _publisher, int _pages)
            : base(_name, _year, _numberOfCopiesInLibrary, _numberOfCopiesTakenByReaders)
        {
            authors = _authors;
            publisher = _publisher;
            pages = _pages;
        }
    }
}
