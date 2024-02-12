using Library.DTO;
using Library.Entites;
using Library.EntityMaps;

namespace Library.Services
{
    public class CategoryService
    {
        public readonly EfDataContext _context;
        public CategoryService()
        {
            _context= new EfDataContext();
        }
        public int AddCategory(int i,AddCategoryDto dto)
        {
            var book=_context.Books.FirstOrDefault(_=> _.Id == i);
            var category = new Category()
            {
                Name = dto.Name,
                BookId=book.Id,
            };
            _context.Categories.Add(category);  
            _context.SaveChanges();
            return category.Id;
        }
        public Book SerchCategory(string Serch)
        {
            var book = _context.Books.Where(_ => _.Name.Contains(Serch)).First();
            return book;
          
        }
        public void DeleteCategoris(int i)
        {
            var category = _context.Categories.Where(_ => _.Id == i).FirstOrDefault();
            if (category == null)
            {
                throw new Exception();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();

        }
    }

}
