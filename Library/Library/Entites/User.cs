namespace Library.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BookCount { get; set; }
        public HashSet<Book> Books { get; set;}
    }
}
