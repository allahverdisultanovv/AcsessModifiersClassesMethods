namespace AccesModifiersClassesBookLibrary
{
    internal class BookLibrary
    {
        private string _name;
        public Book[] _books = new Book[0];

        public string Name
        {

            get { return _name; }
            set { _name = value; }
        }

        public BookLibrary(string name)
        {
            Name = name;
        }

        public void AddBookLibrary(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        public void ShowAll(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Group Name : {Name}  Book Name: {books[i].Name}  Author: {books[i].Author}");
            }
        }
        public void RemoveBook(string name)
        {
            Book[] newArr = new Book[_books.Length - 1];
            int j = 0;
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name != name)
                {
                    newArr[j] = _books[i];
                    j++;
                }
            }
            _books = newArr;
        }
        public void BorrowBook(string name)
        {

            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name == name)
                {
                    _books[i]._isAavailable = false;
                }
            }
        }
        public void ReturnBook(string name)
        {

            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name == name)
                {
                    _books[i]._isAavailable = true;
                }
            }
        }
        public void SearchByAuthor(string name)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Author == name)
                {
                    Console.WriteLine(_books[i].Name);
                }
            }
        }
    }
}
