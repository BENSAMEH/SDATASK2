using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book originalBook = new Book("MESSI", "LEO", 180);
            Console.WriteLine("Original Book:");
            Console.WriteLine(originalBook.Print());

           
            Book clonedBook = originalBook.CreateCopy();

           
            clonedBook.Title = "MESSI - Clone";
            clonedBook.Pages = 160;

            
            Console.WriteLine("\nCloned Book:");
            Console.WriteLine(clonedBook.Print());

           
        }
    }
    public interface IPrototype
    {
         Book CreateCopy();
    }

   
    public class Book : IPrototype
    {
        public string Title;
        public string Author;
        public int Pages;

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        
        public  Book CreateCopy()
        {
            return (Book)this.MemberwiseClone();
        }

        public  string Print()
        {
            return $"Title: {Title}, Author: {Author}, Pages: {Pages}";
        }
    }

   
}
