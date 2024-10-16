using AccesModifiersClassesBookLibrary;

Book book = new Book("AntiChirst", "Fridrich Nietsche", true);
Book book4 = new Book("Nihilism", "Fridrich Nietsche", true);

Book book2 = new Book("Love and Peace", "Lev Tolstoy");
Book book3 = new Book("Secme Eserler", "Sebahattin Ali");


book.GetInfo();

BookLibrary bookLibrary = new BookLibrary("Western Literature");
BookLibrary bookLibrary2 = new BookLibrary("Russian Literature");


bookLibrary.AddBookLibrary(book);
bookLibrary.AddBookLibrary(book4);

bookLibrary2.AddBookLibrary(book2);
bookLibrary2.AddBookLibrary(book3);

//bookLibrary2.ShowAll(bookLibrary2._books);
//Console.WriteLine("++++++++++++++++++++++++++++++");

//bookLibrary2.RemoveBook("Secme Eserler");
//bookLibrary2.ShowAll(bookLibrary2._books);


bookLibrary.BorrowBook("AntiChirst");



Console.WriteLine("+++++++++++++++++++++");
book.GetInfo();

Console.WriteLine("+++++++++++++++++++++");
bookLibrary.ReturnBook("AntiChirst");

book.GetInfo();

Console.WriteLine("+++++++++++++");
bookLibrary.SearchByAuthor("Fridrich Nietsche");
