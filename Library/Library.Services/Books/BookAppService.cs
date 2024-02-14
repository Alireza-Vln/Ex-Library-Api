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

        public async Task DeleteBook(int id)
        {
           _repository.DeleteBook(id);
          await _unitOfWork.Complete();
        }

        public async Task<List<GetBooksDto>> GetAllBooks()
        {
            return _repository.GetAllBooks();

        }

    }
}

