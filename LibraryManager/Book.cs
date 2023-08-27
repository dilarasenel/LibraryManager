namespace examples
{
    public class Book
    {
        private List<Author> _authors;
        private List<Genre> _genres;

        public string Title { get; init; } // dışardan bi kullanıcının bunu okumasını ama değiştirmemesini istiyorum!!!
        public string ISBN { get; init; }

        public Book(string title, string isbn) //Construct etmiş olduk yoksa _authors null döner!!
        {
            Title = title;
            ISBN = isbn;
            _authors = new List<Author>();
            _genres = new List<Genre>();
        }

        public void AddAuthor(Author author)
        {
            _authors.Add(author);
        }
        public void AddGenre(Genre genre)
        {
            _genres.Add(genre);
        }

    }
    
}
