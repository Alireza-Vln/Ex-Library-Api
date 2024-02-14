using Library.DTO;
using Library.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Book.Cantract
{
    public interface  BookRepository
    {
        void AddBook(Entites.Book book ,int i);
         List<GetBooksDto> GetAllBooks();
        void DeleteBook(int id);
    }
}
