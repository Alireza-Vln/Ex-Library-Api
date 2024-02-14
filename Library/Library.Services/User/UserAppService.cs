using Cantracts;
using Library.DTO;
using Library.Entites;
using Library.Services.User.Cantract;

namespace Library.Services
{
    public class UserAppService : UserService
    {
        readonly UnitOfWork _unitOfWork;
        readonly UserRepository _repository;
        public UserAppService(UserRepository repository, UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

            _repository = repository;
        }


        public async Task AddUser(AddUserDto dto)
        {
            var user = new Entites.User()
            {
                Name = dto.Name,
            };
            _repository.AddUser(user);
           await _unitOfWork.Complete(); 
        }

        public async Task DeleteUser(int id)
        {
           _repository.DeleteUser(id);
           await _unitOfWork.Complete();
        }

        public async Task<List<GetUserDto>> GetAllUsers()
        {
          return _repository.GetAllUsers();
            
        }

        public async Task RentBook(int BookId, int UserId)
        {
            _repository.RentBook(BookId, UserId);
            await _unitOfWork.Complete();
        }

      
        //public void DeleteUser(int i)
        //{
        //    var user = _context.Users.Where(_=> _.Id == i).FirstOrDefault();
        //    if (user == null)
        //    {
        //        throw new Exception();
        //    }
        //    _context.Users.Remove(user);
        //    _context.SaveChanges();

        //}

    }
}
