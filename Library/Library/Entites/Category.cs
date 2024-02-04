namespace Library.Entites
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
