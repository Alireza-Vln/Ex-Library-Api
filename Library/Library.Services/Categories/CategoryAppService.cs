using Cantracts;
using Library.DTO;
using Library.Entites;
using Library.Services.Categories.Cantract;

namespace Library.Services
{
    public class CategoryAppService : CaregoryService
    {
        readonly UnitOfWork _unitOfWork;
        readonly CategoryRepository _repository;
        public CategoryAppService(CategoryRepository repository,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public async Task AddCategory(AddCategoryDto dto, int i)
        {
            var category = new Category()
            {
                Name = dto.Name,
            };
            _repository.AddCategory(category, i);
            await _unitOfWork.Complete();
        }





        //    public readonly EfDataContext _context;
        //    public CategoryAppService()
        //    {
        //        _context = new EfDataContext();
        //    }
        //    public int AddCategory(int i, AddCategoryDto dto)
        //    {
        //        var book = _context.Books.FirstOrDefault(_ => _.Id == i);
        //        var category = new Category()
        //        {
        //            Name = dto.Name,
        //            BookId = book.Id,
        //        };
        //        _context.Categories.Add(category);
        //        _context.SaveChanges();
        //        return category.Id;
        //    }
        //    public Book SerchCategory(string Serch)
        //    {
        //        var book = _context.Books.Where(_ => _.Name.Contains(Serch)).First();
        //        if (book == null)
        //        {
        //            throw new Exception();
        //        }
        //        return book;

        //    }
        //    public void DeleteCategoris(int i)
        //    {
        //        var category = _context.Categories.Where(_ => _.Id == i).FirstOrDefault();
        //        if (category == null)
        //        {
        //            throw new Exception();
        //        }
        //        _context.Categories.Remove(category);
        //        _context.SaveChanges();

        //    }
        //}

    }
}
