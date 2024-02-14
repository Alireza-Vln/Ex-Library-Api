using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.User.Cantract
{
    public interface UserService
    {
        public Task AddUser(AddUserDto dto);
        public Task<List<GetUserDto>> GetAllUsers();
        public Task RentBook(int BookId,int UserId);
        public Task DeleteUser(int id);
    }
}
