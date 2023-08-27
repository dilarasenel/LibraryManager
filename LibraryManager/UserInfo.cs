namespace examples
{
    internal class UserInfo
    {
        private List<Book> _books;
        public string UserName { get; init; }
        public string UserLastName { get; init; }
        public int UserId { get; init; }    

        public UserInfo(string userName,string lastName,int id )
        {
            UserName = userName;
            UserLastName = lastName;
            UserId = id;
            _books = new List<Book>();
        }

    }
}