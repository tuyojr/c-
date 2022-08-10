using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    internal class Book
    {
        //class tells us what the book dataType is
        //class attributes
        public string Title;
        public string Author;
        public int Pages;


        //create a method with no parameters or with parameters
        //public Book()
        //{

        //}
        public Book(string aTitle, string anAuthor, int numPages) //we can let it accept parameters
        {
            Title = aTitle;
            Author = anAuthor;
            Pages = numPages;
        }


    }
}
