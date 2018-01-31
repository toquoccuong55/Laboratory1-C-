using System;
using Menu;
using BookLib;
namespace BookManager
{
    public class Util
    {
        public static string getString(string msg, string error)
        {
            string result = "";
            while (true) {
                try
                {
                    Console.WriteLine(msg);
                    result = Console.ReadLine();
                    if (result.Length == 0)
                    {
                        Console.WriteLine(error);
                    }
                    else
                    {
                        return result;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MenuForm mn = new MenuForm();
            mn.addMenuItem("1. Add a book");
            mn.addMenuItem("2. Find a book");
            mn.addMenuItem("3. Show book list");
            mn.addMenuItem("4. Remove a book");
            mn.addMenuItem("5. Exit");
            int choice = 0;
            BookLibrary bookLibrary = new BookLibrary();
            do
            {
                Console.WriteLine("********** Book Management **********");
                choice = mn.GetChoice(0,5);
                switch (choice)
                {
                    case 1:
                        string id = Util.getString("Input ID: ","ID is invalid");
                        string name = Util.getString("Input Book Name: ", "Book name is invalid");
                        string author = Util.getString("Input Author: ", "Author is invalid");
                        string publisher = Util.getString("Input Publisher: ", "Publisher is invalid");
                        Book book = new Book(id, name, author, publisher);
                        bookLibrary.AddBook(book);
                        Console.WriteLine("Added new book!");
                        break;
                    case 2:
                        string searchedID = Util.getString("Input ID to find book: ", "ID is invalid");
                        Book foundBook = bookLibrary.FindBook(searchedID);
                        if(foundBook != null)
                        {
                            Console.WriteLine(foundBook.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                        break;
                    case 3:
                        bookLibrary.ShowBookList();
                        break;
                    case 4:
                        string removedID = Util.getString("Input ID to remove book: ", "ID is invalid");
                        bool removed = bookLibrary.RemoveBook(removedID);
                        if (removed)
                            Console.WriteLine("Removed " + removedID + " book successfully");
                        else
                            Console.WriteLine("Removed " + removedID + " book failed");
                        break;
                }
            } while (choice > 0 && choice < 5);
            
        }
    }
}
