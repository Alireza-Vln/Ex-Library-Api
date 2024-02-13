using Cantracts;
using Library.DTO;
using Library.Entites;
using Library.Services.Author.Cantract;
using Library.Services.Authors.Cantract.Dtos;

namespace Library.Services
{
    public class AuthorAppService : AuthorService
    {
        readonly UnitOfWork _unitOfWork;
        readonly AuthorRespository _respository;
        public AuthorAppService(AuthorRespository respository,UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
             _respository = respository;
        }
 

        public async Task AddAuthor(AddAuthorDto Dto)
        {
            var athuor = new Entites.Authors
            {
                Name = Dto.Name,
            };
           _respository.AddAuthor(athuor);
            await _unitOfWork.Complete();
        }

        public async Task DeleteAuthor(int id)
        {
            _respository.DeleteAuthor(id);
          await _unitOfWork.Complete();
        }

        public async Task<List<GetAuthorDto>> GetAllAuthor()
        {
            return  _respository.GetAllAuthor();
        }

    }
}
