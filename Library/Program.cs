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
            while (close)
            {
                Console.WriteLine("\nMenu\n" +
                           "1)Add book\n" +
                            "2)Delete book\n" +
                            "3)Update book\n" +
                            "4)GetDetails\n\n");
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
                        management.UpdateBook();
                        break;
                    case 4:
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