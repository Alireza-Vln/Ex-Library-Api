namespace Library.Entites
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int RentBook { get; set; }
        public Authors Author { get; set; }
        public int AuthorId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public HashSet<Category> Categories { get; set; }






    }
}
