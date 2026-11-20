using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_basics_session02_Assignments_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1,Q2
            //Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object.Print it.
            //Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on boo

            //Book book = new Book() { Pages = 300, Title = "Learn .Net" };
            //object Books = book;

            //Console.WriteLine(Books);
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Q3
            // Q03.Look at the line below.Is it a compile - time error, a runtime error, or a logical error? Fix it.
            //int Pages = "464";
            //int Pages = 464; // compile-time (Syntax Error) remove ""

            #endregion

            #region Q4 
            //Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    Console.WriteLine(x/y);
            //}
            //catch (DivideByZeroException) // catch (Exception)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Q5
            //Q05.Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double DPages = pages;
            //Console.WriteLine(DPages);

            #endregion

            #region Q6
            //Q06.Declare a double price = 49.99; then convert it into an int using a cast.
            //double Dprice = 49.99;
            //int price = (int)Dprice;
            //Console.WriteLine(price);

            #endregion

            #region Q7
            //Q07.Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            //Console.WriteLine(Convert.ToInt32(pagesText));
            #endregion

            #region Q8
            //Q08.Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //string badText = "abc";

            //Console.WriteLine(year);
            //bool trynumber = int.TryParse(badText, out int number);
            //if (!trynumber)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            //else
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Q9
            //Q09.Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            int pages = 464;
            Console.WriteLine(pages.ToString().GetType());
            string pagesText = pages.ToString();
            Console.WriteLine(pagesText.GetType());

            #endregion
        }
    }
}
