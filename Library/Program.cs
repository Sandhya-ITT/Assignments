using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class libraryManagement
    {
        static void Main(string[] args)
        {
            bool close = true;
            Details management = new Details();
            management.createfile();
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
                            "1)Add book\n" +
                            "2)Delete book\n" +
                            "3)Get the number of lines in the file\n" +
                            "4)Get the last line from the file\n" +
                            "5)GetDetails\n\n");
                Console.WriteLine("Choose your option from menu :");
                
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        management.AddBook();
                        break;
                    case 2:
                        management.DeleteBook();
                        break;
                    case 3:
                        management.CountNumberOfLinesInTheFile();
                        break;
                    case 4:
                        management.GetTheLastLineFromTheFile();
                        break;
                    case 5:
                        management.GetDetails();
                        break;
                    default:
                        Console.WriteLine("Invalid option\nRetry !!!");
                        break;

                }

            }
        }
    }
}