using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Author.Cantract
{
    public interface AuthorService
    {
        public Task AddAuthor(AddAuthorDto Dto);
    }
}
