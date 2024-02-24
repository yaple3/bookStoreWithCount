namespace bookStore
{
    class Book
    {
        //Variables, fields, properties, and methods specific to books

        private int _Id;

        private string _Title;

        private string _Author;

        private static int _Transactions = 0;

        //Constructors

        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;

        }

        //Getters & Setters

        public int GetId() => _Id;

        public void SetId(int id) => _Id = id;

        public string GetTitle() => _Title;

        public void SetTitle(string title) => _Title = title;

        public string GetAuthor() => _Author;

        public void SetAuthor(string author) => _Author = author;

        public static int GetTrans() => _Transactions;

        public static void SetTrans() => _Transactions++;


    }

    class myStore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Bookstore!");

            Book book1 = new Book();
            book1.SetId(30);
            book1.SetTitle("Jesus and John Wayne");
            book1.SetAuthor("Kristin Kobes Du Mez");
            Book.SetTrans();

            Book book2 = new Book();
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author: ");
            book2.SetAuthor(Console.ReadLine());
            Book.SetTrans();

            Book book3 = new Book(18, "Drawing on the Right Side of the Brain", "Betty Edwards");
            Book.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author: ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempID, tempTitle, tempAuthor);
            Book.SetTrans();

            //Display transactions and book details
            displayTransactions(book1);
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);


            Console.WriteLine("Thank you for visiting!");

        }
        static void displayTransactions(Book book)
        {
            Console.WriteLine($"Transactions: {Book.GetTrans()}");
        }
        static void displayBooks(Book book)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
        }

    }
}

