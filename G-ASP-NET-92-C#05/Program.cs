namespace G_ASP_NET_92_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Question01
            //// ---------
            //// Q: Add a private string password = "secret"; field to a Book class.
            //// Try to print it from Main (outside the class). What happens, and why?
            //// ---------

            //Book book = new Book();

            //// Console.WriteLine(book.password);
            //// Why: This gives an error because private fields can only be accessed inside the Book class.

            //// commit fix

            //#endregion


            #region Question02
            // ---------
            // Q: Add an internal int copiesInStock = 5; field to Book.
            // Print it from Main. Does it compile? Why?
            // ---------

            Book book = new Book();

            Console.WriteLine(book.copiesInStock);

            // Why: It compiles because internal members can be accessed from anywhere in the same project.

            #endregion

        }
        class Book
        {
            private string password = "secret";
            internal int copiesInStock = 5;

        }

    }
}
