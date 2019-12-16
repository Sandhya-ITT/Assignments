using System;
using System.IO;
using System.Linq;

namespace Library
{
    class Details
    {
        Book[] arr = new Book[10];
        string fileName = @"C:\Users\sandhya.e\Desktop\Examplefile.txt";

        public long CountNumberOfLinesInTheFile()
        {
            var lineCounter = 0;
            using (var reader = new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCounter++;
                    Console.WriteLine();
                }
                Console.WriteLine(lineCounter);
                return lineCounter;
            }
        }

        public void GetTheLastLineFromTheFile()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\sandhya.e\Desktop\Examplefile.txt");
            while ((line = file.ReadLine()) != null)
            {
                string lastWord = line.Split(' ').Last();
            }

            file.Close();

        }

        public void createfile()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    FileStream fs = File.Create(fileName);

                }
            }
            catch (IOException e)
            {

                Console.WriteLine(e.StackTrace);
            }
        }

        public void Writeoperation(Book info)
        {
            try
            {
                StreamWriter sw = File.AppendText(fileName);
                sw.WriteLine(info);
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //To add the book
        public Book AddBook()
        {
            Book book = new Book();

            Console.Write("Enter the Book Name:");
            book.BookName = Console.ReadLine();
            Console.Write("Enter the AuthorName:");
            book.BookAuthor = Console.ReadLine();
            Console.Write("Enter the category:");
            book.BookCategory = Console.ReadLine();

            this.Writeoperation(book);
            return book;

        }

        //To delete the book
        public void DeleteBook()
        {
            Console.WriteLine("Are you sure you want to delete the file Y/N");
            string DeleteFile = Console.ReadLine();
            if(DeleteFile == "yes" || DeleteFile == "Y")  
            {
                File.Delete(fileName);
            }
        }

//To display the details
        public void GetDetails()
        {
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string stringHolder = "";
                    while ((stringHolder = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(stringHolder);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}