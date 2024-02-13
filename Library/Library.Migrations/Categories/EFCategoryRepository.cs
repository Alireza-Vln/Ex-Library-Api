using Library.Entites;
using Library.EntityMaps;
using Library.Services.Categories.Cantract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.EFCategoryRepository
{
    public class EFCategoryRepository : CategoryRepository
    {
        private readonly EfDataContext _context;
        public EFCategoryRepository(EfDataContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category, int i)
        {
            var book=_context.Books.FirstOrDefault(_=>_.Id == i);
            if (book == null)
            {
                throw new Exception("Not found");
            }
            category.BookId = book.Id;
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
}
