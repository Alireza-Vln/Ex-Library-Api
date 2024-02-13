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
    }
}
