using Library.DTO;
using Library.Services.Authors.Cantract.Dtos;
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
        public Task<List<GetAuthorDto>> GetAllAuthor();
        public Task DeleteAuthor(int id);
    }
}
