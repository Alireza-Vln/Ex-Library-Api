using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class AuthorService
    {
        private readonly EfDataContext _context;
        public AuthorService()
        {
            _context=new EfDataContext();
        }
        public int AddAuthor(AddAuthorDto dto)
        {
          
            var author = new Author
            {
                Name = dto.Name
            };

            _context.Authors.Add(author);
            _context.SaveChanges();

            return author.Id;
        }
        public DbSet<Author> GetAuthors()
        {
            return _context.Authors;
        }
        public void DeletAuthor(int id) 
       {
         
            var delete=_context.Authors.Where(_=>_.Id==id).First();
            _context.Authors.Remove(delete);
            
        }
    }
}
