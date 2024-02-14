using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.User.Cantract
{
   public interface UserRepository
    {
          void AddUser(Entites.User user);
        List<GetUserDto> GetAllUsers();
        void RentBook(int BookId, int UserId);
        void DeleteUser(int id);
    }
}
