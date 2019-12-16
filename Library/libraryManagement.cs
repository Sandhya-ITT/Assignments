using System;

namespace Library
{
    class Details
    {
        Book[] arr = new Book[10];

        //To add the book
        public void AddBook()
        {
            Book book = new Book();

            Console.Write("Enter the Book Name:");
            book.BookName = Console.ReadLine();
            Console.Write("Enter the AuthorName:");
            book.BookAuthor = Console.ReadLine();
            Console.Write("Enter the category:");
            book.BookCategory = Console.ReadLine();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = book;
                    break;
                }
            }

        }

        //To delete the book
        public void DeleteBook()
        {

            Console.WriteLine("Enter the BookCategory you wanted to delete");
            string DeletedInfo = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != null)
                {
                    if (arr[i].BookName == DeletedInfo)
                    {
                        Console.WriteLine("book details matched and deleted: {0}", arr[i]);
                        arr[i] = null;
                        break;
                    }

                }
                else if (arr.Length == (i + 1))
                {
                    Console.WriteLine("No book matched!!: {0} ", DeletedInfo);
                }

            }


        }

        //To update the book
        public void UpdateBook()
        {
            Book book = new Book();

            Console.WriteLine("Enter the Details to be updated ");
            string UpdatedInfo = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    if (arr[i].BookName == UpdatedInfo)
                    {
                        Console.WriteLine(" Enter Book Name:");
                        book.BookName = Console.ReadLine();
                        Console.WriteLine(" Enter Author Name:");
                        book.BookAuthor = Console.ReadLine();
                        Console.WriteLine(" Enter Book Category:");
                        book.BookCategory = Console.ReadLine();
                        Console.WriteLine("Successfully updated!!!");
                        Console.WriteLine(arr[i] = book);
                        break;
                    }
                }
                else if (arr.Length == (i + 1))
                {
                    Console.WriteLine("No book matched with Book Category!!!: {0} ", UpdatedInfo);
                }
            }
        }

        //To display the details
        public void GetDetails()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                    Console.WriteLine(arr[i]);
            }
        }
    }
}