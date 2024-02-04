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
        public void RentBook(string user,string book)
        {
            var buy = _context.Books.Where(_ => _.Name == book && _.User.Name == user).FirstOrDefault();
            buy.Count--;
            buy.RentBook++;
            buy.User.BookCount++;
            _context.SaveChanges();
        }
    }
}
