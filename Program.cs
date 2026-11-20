namespace c_basics_session02_Assignments_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1,Q2
            //Q01.Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a variable of type object.Print it.
            //Q02.Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on boo

            Book book = new Book() { Pages = 300, Title = "Learn .Net" };
            object Books = book;

            Console.WriteLine(Books);
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            #endregion
        }
    }
}
