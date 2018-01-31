using System;
using System.Collections;

namespace BookLib
{
    public class Book
    {
        string id, name, author, publisher;

        public Book()
        {
        }
        public Book(string ID, string Name, string Author, string Publisher)
        {
            this.Id = ID;
            this.Name = Name;
            this.Author = Author;
            this.Publisher = Publisher;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public override string ToString()
        {
            string result ="ID: " + id + "\nName: " + name + "\nAuthor: " + author 
                + " \nPublisher: " + publisher;
            return result;
        }

    }

    public class BookLibrary
    {
        ArrayList list;

        public BookLibrary()
        {
            list = new ArrayList();
        }
        public bool AddBook(Book b)
        {
            if(b != null)
            {
                list.Add(b);
                return true;
            }
            return false;
        }
        public Book FindBook(string id)
        {
            foreach (Book b in list)
            {
                if (b.Id.Equals(id))
                {
                    return b;
                }
            }
            return null;
        }
        public void ShowBookList()
        {
            int count = 0;
            foreach (Book b in list)
            {
                Console.Write("(" + count + ")" + b.ToString());
                Console.WriteLine();
                Console.WriteLine();
                count++;
            }
        }
        public bool RemoveBook(string id)
        {
            foreach (Book b in list)
            {
                if (b.Id.Equals(id))
                {
                    list.Remove(b);
                    return true;
                }
            }
            return false;
        }

    }
}
