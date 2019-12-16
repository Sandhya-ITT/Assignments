using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string BookName
        {
            get; set;
        }
        public string BookAuthor
        {
            get; set;
        }
        public string BookCategory
        {
            get; set;
        }

        public override string ToString()
        {
            return BookName + " "
                + BookAuthor
                + " " + BookCategory;
        }

    }


}