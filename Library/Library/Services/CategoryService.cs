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
        public int AddCategory(AddCategoryDto dto)
        {

            var category = new Category()
            {
                Name = dto.Name,

            };
            _context.Categories.Add(category);  
            _context.SaveChanges();
            return category.Id;
        }
        public List<Book>SerchCategory(string Serch)
        {
            var book = _context.Books.Where(_ => _.Name.Contains(Serch));
            return book.ToList();
          
        }
    }

}
