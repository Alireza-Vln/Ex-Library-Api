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
                Name = dto.Name,
                
            };
           

            _context.Authors.Add(author);
            _context.SaveChanges();
            return author.Id;
        }

        public List<GetAothorDto> GetAuthor()
        {
            return (from at in _context.Set<Author>()
                    join bo in _context.Books
                    on at.Id equals bo.UserId
                    into temp
                    from bo in temp.DefaultIfEmpty()

                    select new GetAothorDto
                    {
                        AuthorName = at.Name,
                        BookName = bo.Name,
                    } ).ToList();
        }
        public void DeletAuthor(int id) 
       {
         
            var delete=_context.Authors.Where(_=>_.Id==id).First();
            _context.Authors.Remove(delete);
            
        }
    }
}
