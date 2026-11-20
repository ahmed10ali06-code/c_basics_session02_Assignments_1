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
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x/y);
            }
            catch (DivideByZeroException) // catch (Exception)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
        }
    }
}
