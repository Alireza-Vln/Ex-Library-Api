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
            _context.SaveChanges();
        }
    }
}
