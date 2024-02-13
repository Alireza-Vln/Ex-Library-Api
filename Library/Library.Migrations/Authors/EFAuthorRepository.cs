using Library.Entites;
using Library.EntityMaps;
using Library.Services.Author.Cantract;
using Library.Services.Authors.Cantract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.EFAuthorRepository
{
    
    
    public class EFAuthorRepository : AuthorRespository
        
    {
     
        private readonly EfDataContext _context;

        public EFAuthorRepository(EfDataContext context)
        {
           
            _context = context;
        }
        public void AddAuthor(Authors author)
        {
            _context.Authors.Add(author);
          
        }

        public void DeleteAuthor(int id)
        {
            var delete = _context.Authors.Where(_ => _.Id == id).First();
            if (delete == null)
            {
                throw new Exception("Not found");
            }
            _context.Authors.Remove(delete);
           
        }

        public List<GetAuthorDto> GetAllAuthor()
        {
            return (from at in _context.Authors
                   join bo in _context.Books
                   on at.Id equals bo.AuthorId
                   into temp
                   from bo in temp.DefaultIfEmpty()
                   select new GetAuthorDto
                  {
                       Id =at.Id,
                      AuthorName = at.Name,
                      BookName = bo.Name,

                  }).ToList();
        }
    }
}
