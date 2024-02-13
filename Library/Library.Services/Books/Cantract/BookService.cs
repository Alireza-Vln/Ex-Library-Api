using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Book.Cantract
{
    public interface BookService
    {
        public Task AddBook(AddBookDto dto , int i);
    }
}
