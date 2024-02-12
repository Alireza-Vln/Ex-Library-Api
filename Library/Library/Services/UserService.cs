using Library.DTO;
using Library.Entites;
using Library.EntityMaps;

namespace Library.Services
{
    public class UserService
    {
        public readonly EfDataContext _context;
        public UserService()
        {
                _context= new EfDataContext();
        }
        public int AddUser(AddUserDto dto)
        {
            var user = new User
            {
                Name = dto.Name,

            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
            
        }
        public void RentBook(int BookId,int UserId)
        {
            var buybook = _context.Books.FirstOrDefault(_ => _.Id == BookId);
            if (buybook == null)
            {
                throw new Exception();
            }
            var userbook=_context.Users.FirstOrDefault(_ => _.Id == UserId);
            if (userbook == null)
            {
                throw new Exception();
            }
            buybook.UserId = UserId;
            if (buybook.Count < 0) { throw new Exception(); }  
            buybook.Count--;
            buybook.RentBook++;
           userbook.BookCount++;
            _context.SaveChanges();
        }
        public List<GetUserDto> GetUsers()
        {
           return( from us in _context.Set<User>()
            join bo in _context.Books
            on us.Id equals bo.UserId
            into temp
            from bo in temp.DefaultIfEmpty()

            select new GetUserDto
            {
                UserName = us.Name,
                BookName =bo.Name,
                CountBook=us.BookCount,

            }).ToList();
        }
        public void DeleteUser(int i)
        {
            var user = _context.Users.Where(_=> _.Id == i).FirstOrDefault();
            if (user == null)
            {
                throw new Exception();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();

        }
    }
}
