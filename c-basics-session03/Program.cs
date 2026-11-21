using System.Text;

namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            // Q1
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);       
            //Console.WriteLine(upperTitle);  

            // Q2
            //string s1 = "Clean Code";
            //string s2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(s1, s2)); 

            // Q3
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb); 

            // Q4
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb); 

            // Q5
            //string bookTitle = "Clean Code";
            //int pages = 464;
            //string sentence1 = "Book: " + bookTitle + ", Pages: " + pages;
            //Console.WriteLine(sentence1);

            // Q6
            //string sentence2 = $"Book: {bookTitle}, Pages: {pages}";
            //Console.WriteLine(sentence2);

            // Q7
            //string sentence3 = string.Format("Book: {0}, Pages: {1}", bookTitle, pages);
            //Console.WriteLine(sentence3);

            // Q8
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            // Q9
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}

            // Q10
            //string name = "Refactoring";
            //switch (name)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            // Q11
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            //// Q12
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}

            
            // Q13
            //int index = 0;
            //while (index < books.Length)
            //{
            //    Console.WriteLine(books[index]);
            //    index++;
            //}

            // Q14 
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    count++;
            //} while (count < 3);

            // Q15 
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            // Q16 
            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //        break;
            //    Console.WriteLine(book);
            //}

            // Q17
            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine(book);
            //}

            // Q18 
            //PrintFirstBook(books);
            //PrintFirstBook(new string[0]); 

            //void PrintFirstBook(string[] bookList)
            //{
            //    if (bookList.Length == 0)
            //    {
            //        return; 
            //    }
            //    Console.WriteLine(bookList[0]);
            //}
        }
    }
}
