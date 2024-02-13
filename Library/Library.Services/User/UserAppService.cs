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

        //public void RentBook(int BookId,int UserId)
        //{
        //    var buybook = _context.Books.FirstOrDefault(_ => _.Id == BookId);
        //    if (buybook == null)
        //    {
        //        throw new Exception();
        //    }
        //    var userbook=_context.Users.FirstOrDefault(_ => _.Id == UserId);
        //    if (userbook == null)
        //    {
        //        throw new Exception();
        //    }
        //    buybook.UserId = UserId;
        //    if (buybook.Count < 0) { throw new Exception(); }  
        //    buybook.Count--;
        //    buybook.RentBook++;
        //   userbook.BookCount++;
        //    _context.SaveChanges();
        //}
        //public List<GetUserDto> GetUsers()
        //{
        //   return( from us in _context.Set<User>()
        //    join bo in _context.Books
        //    on us.Id equals bo.UserId
        //    into temp
        //    from bo in temp.DefaultIfEmpty()

        //    select new GetUserDto
        //    {
        //        UserName = us.Name,
        //        BookName =bo.Name,
        //        CountBook=us.BookCount,

        //    }).ToList();
        //}
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
