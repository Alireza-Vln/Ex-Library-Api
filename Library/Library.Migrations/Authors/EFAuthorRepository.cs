using Library.Entites;
using Library.EntityMaps;
using Library.Services.Author.Cantract;
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
        public void AddAthour(Authors author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
}
