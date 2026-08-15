namespace G_ASP_NET_92_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            // ---------
            // Q: Add a private string password = "secret"; field to a Book class.
            // Try to print it from Main (outside the class). What happens, and why?
            // ---------

            Book book = new Book();

            // Console.WriteLine(book.password);
            // Why: This gives an error because private fields can only be accessed inside the Book class.

            #endregion

        }
        class Book
        {
            private string password = "secret";

        }

    }
}
