using Cantracts;
using Library.DTO;
using Library.Entites;

using Library.Services.Book.Cantract;

using Microsoft.SqlServer.Server;

namespace Library.Services
{
    public class BookAppService : BookService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly BookRepository _repository;
        public BookAppService(BookRepository repository,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task AddBook(AddBookDto dto, int i)
        {
            

            var book = new Entites.Book
            {
                Name = dto.Name,
                Count = dto.Count,
                
            };
            _repository.AddBook(book, i);
          await _unitOfWork.Complete();

        }

     
        //public List<GetBooksDto> GetBook()
        //{
        //    return (from bo in _context.Set<Book>()
        //            join ath in _context.Authors
        //            on bo.AuthorId equals ath.Id
        //            into temp
        //            from ath in temp.DefaultIfEmpty()
        //            select new GetBooksDto
        //            {
        //                BookId = bo.Id,
        //                Name = bo.Name,
        //                Authorname = ath.Name,
        //                Count = bo.Count,
        //                RentBook = bo.RentBook,

        //            }).ToList();

        //}
        //public void DeletBook(int id)
        //{
        //    var delete = _context.Books.Where(_ => _.Id == id).First();
        //    if (delete == null)
        //    {
        //        throw new Exception();
        //    }
        //    _context.Books.Remove(delete);
        //    _context.SaveChanges();
        //}

    }
}

