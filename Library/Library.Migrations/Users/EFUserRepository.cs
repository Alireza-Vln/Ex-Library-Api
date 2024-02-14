using Library.DTO;
using Library.Entites;
using Library.EntityMaps;
using Library.Services.User.Cantract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Users
{
    public class EFUserRepository : UserRepository
    {
        private readonly EfDataContext _context;
        public EFUserRepository(EfDataContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {

            _context.Users.Add(user);

        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Where(_ => _.Id == id).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("NotFound");
            }
            _context.Users.Remove(user);

            

        }

        public List<GetUserDto> GetAllUsers()
        {

            return (from us in _context.Users
                    join bo in _context.Books
                    on us.Id equals bo.UserId
                    into temp
                    from bo in temp.DefaultIfEmpty()

                    select new GetUserDto
                    {
                        Id = us.Id,
                        UserName = us.Name,
                        BookName = bo.Name,
                        CountBook = us.BookCount,

                    }).ToList();

        }

        public void RentBook(int BookId, int UserId)
        {
            var buybook = _context.Books.FirstOrDefault(_ => _.Id == BookId);
            if (buybook == null)
            {
                throw new Exception("Not Found");
            }
            var userbook = _context.Users.FirstOrDefault(_ => _.Id == UserId);
            if (userbook == null)
            {
                throw new Exception("Not Found");
            }
            buybook.UserId = UserId;
            if (buybook.Count == 0 || buybook.RentBook>4)
            {
                throw new Exception("Error"); 
            }

            buybook.Count--;
            buybook.RentBook++;
            userbook.BookCount++;
        
        }
    }
}
