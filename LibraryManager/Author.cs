namespace examples
{
    public class Author
    {
        private List<Book> _book;
        public string Name { get; init; }    
        public string LastName { get; init; }
        
    }
    public void AddBook(Book book)
    {
        _book.AddBook(book);
    }
}