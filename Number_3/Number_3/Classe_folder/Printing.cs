using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_3.Classe_folder
{
    class Printing
    {
        private string name;
        private int yearOfPublishing;
        private int numberOfCopiesInLibrary;
        private int numberOfCopiesTakenByReaders;

        public Printing() { }

        public Printing(string _name, int _yearOfPublishing, int _numberOfCopiesInLibrary, int _numberOfCopiesTakenByReaders)
        {
            name = _name;
            yearOfPublishing = _yearOfPublishing;
            numberOfCopiesInLibrary = _numberOfCopiesInLibrary;
            numberOfCopiesTakenByReaders = _numberOfCopiesTakenByReaders;
        }

        public void addCopiesToLibrary(int value)
        {
            numberOfCopiesInLibrary += value;
        }

        public void deleteCopiesFromLibrary(int value)
        {
            if (numberOfCopiesInLibrary >= value)
            {
                numberOfCopiesInLibrary -= value;
            }
        }

        public void addCopiesTakenByReaders(int value)
        {
            numberOfCopiesTakenByReaders += value;
        }

        public void deleteCopiesTakenByReaders(int value)
        {
            if (numberOfCopiesTakenByReaders >= value)
            {
                numberOfCopiesTakenByReaders -= value;
            }
        }
    }
}