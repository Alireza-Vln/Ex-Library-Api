using Library.Entites;
using Library.Services.Authors.Cantract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Author.Cantract
{
    public interface AuthorRespository
    {
        void AddAuthor(Entites.Authors author);
        List<GetAuthorDto> GetAllAuthor();
        void DeleteAuthor(int id);
    }
}
