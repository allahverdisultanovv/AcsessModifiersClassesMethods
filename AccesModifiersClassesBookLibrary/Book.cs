namespace AccesModifiersClassesBookLibrary
{
    internal class Book
    {
        private string _name;
        private string _author;
        public bool _isAavailable;

        public string Name
        {

            get { return _name; }
            set { _name = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public Book(string name, string author, bool isAvailable = true)
        {
            Name = name;
            Author = author;
            _isAavailable = isAvailable;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name},  Author: {Author}  , Is have in stock: {_isAavailable}");
        }


    }
}
