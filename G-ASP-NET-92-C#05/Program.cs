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


            //#region Question02
            //// ---------
            //// Q: Add an internal int copiesInStock = 5; field to Book.
            //// Print it from Main. Does it compile? Why?
            //// ---------

            //Book book = new Book();

            //Console.WriteLine(book.copiesInStock);

            //// Why: It compiles because internal members can be accessed from anywhere in the same project.

            //#endregion

            //#region Question03
            //// ---------
            //// Q: Add a public string Title; field to Book.
            //// Set it and print it from Main.
            //// ---------

            //Book book = new Book();

            //book.Title = "Clean Code";

            //Console.WriteLine(book.Title);

            //#endregion

            //#region Question04
            //// ---------
            //// Q: Declare an enum Genre { Fiction, NonFiction, Science }.
            //// Add a Genre property to Book, assign it Genre.Science, and print it.
            //// ---------

            //Book book = new Book();

            //book.Genre = Genre.Science;

            //Console.WriteLine(book.Genre);

            //#endregion

            //#region Question05
            //// ---------
            //// Q: Using the Genre enum above, print the underlying int value of
            //// Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            //// ---------

            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);

            //#endregion

            //#region Question06
            //// ---------
            //// Q: Given int genreNumber = 1;, cast it into a Genre value and print the result.
            //// ---------

            //int genreNumber = 1;

            //Genre genre = (Genre)genreNumber;

            //Console.WriteLine(genre);

            //#endregion

            #region Question07
            // ---------
            // Q: Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            // ---------

            Genre genre = Genre.Fiction;

            string genreText = genre.ToString();

            Console.WriteLine(genreText);

            #endregion


        }
        class Book
        {
            private string password = "secret";
            internal int copiesInStock = 5;
            public string Title;
            public Genre Genre { get; set; }
        }
        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }
    }
}
