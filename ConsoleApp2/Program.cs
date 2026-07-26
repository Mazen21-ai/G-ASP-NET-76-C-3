using System;
using System.ComponentModel.Design;
using System.Text;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            /*
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            */

            /*
             string title1 = "Clean Code";
             string title2 = "Clean Code";
             Console.WriteLine(Object.ReferenceEquals(title1, title2));
            */

            /*
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("- Updated");
            Console.WriteLine(sb);
            */

            /*
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            */

            /*
            string title = "clean code";
            int pages = 464;
            string result = "Book:" + title + ",pages" + pages;
            Console.WriteLine(result); 
            */

            /*
            string title = "clean code";
            int pages = 464;
            string result = $"Book:{title},pages:{pages}";
            Console.WriteLine(result);
            */

            /*
            string title = "clean code";
            int pages = 464;
            string result=string.Format("Book:{0},pages{1}",title,pages);
            Console.WriteLine(result);
            */


            /*
            int pages = 464;
            if (pages > 300)
           {
             Console.WriteLine("Long Book");
           }

           else
           {
              Console.WriteLine("Short Book");

           }
           */

            /*
            int pages = 464;
            bool isAvaialbe=true;
            if(pages > 300 && isAvaialbe)
            {
                Console.WriteLine("You can borrow this book");

            }        
            */

            /*
            string title = "Refacoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great Choice!");
                    break;
                case "Refacoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            */

            /*
            int pages = 464;
            string sizelabel = (pages > 300) ?
                "Long Book" : "Short Book";
            Console.WriteLine(sizelabel);
            */

            /*
            string[] books =
            {
                "Clean Code",
                "The Pragmatic Progammer",
                "Refacoring"
            };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }
            */

            /*
            string[] books =
            {
                "Clean Code",
                "The Pragmatic Progammer",
                "Refacoring"
            };
            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine(books[i]); i++;
            }
            */

            /*
            int i = 1;
            do
            {
                Console.WriteLine("Checking book ..."); i++;
            }
            while (i<=3);
            */


            /*
            string[] books =
           {
                "Clean Code",
                "The Pragmatic Progammer",
                "Refacoring"
            };
            foreach (string book in books) 
            { Console.WriteLine(book); 
            
            }
            */


            /*
            string[] books =
          {
                "Clean Code",
                "The Pragmatic Progammer",
                "Refacoring"
            };
            foreach (string book in books)
            {
                if (book == "Refacoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }
            */

            /*
            string[] books =
        {
                "Clean Code",
                "The Pragmatic Progammer",
                "Refacoring"
            };
            foreach (string book in books)
            {
                if (book == "The Pragmatic Progammer")
                {
                    continue;
                }
                Console.WriteLine(book);
            

            }
            */

            /*

            string[] books =
      {
                "Clean Code",
                "The Pragmatic Progammer",
                "Refacoring"
            };

            PrintFirstBook(books);
            static void PrintFirstBook(string[]books)
            {
                if (books.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books[0]);
            }
            */


































        }
    }
}
