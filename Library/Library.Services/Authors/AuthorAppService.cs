using Library.DTO;
using Library.Entites;
using Library.Services.Author.Cantract;

namespace Library.Services
{
    public class AuthorAppService : AuthorService
    {
        readonly AuthorRespository _respository;
        public AuthorAppService(AuthorRespository respository)
        {
             _respository = respository;
        }
 

        public async Task AddAuthor(AddAuthorDto Dto)
        {
            var athuor = new Authors
            {
                Name = Dto.Name,
            };
            _respository.AddAthour(athuor);
        }











        // public int AddAuthor(AddAuthorDto dto)
        // {


        //     var author = new Author
        //     {

        //         Name = dto.Name,

        //     };


        //     _context.Authors.Add(author);
        //     _context.SaveChanges();
        //     return author.Id;
        // }

        // public List<GetAothorDto> GetAuthor()
        // {
        //     return (from at in _context.Set<Author>()
        //             join bo in _context.Books
        //             on at.Id equals bo.UserId
        //             into temp
        //             from bo in temp.DefaultIfEmpty()

        //             select new GetAothorDto
        //             {
        //                 AuthorName = at.Name,
        //                 BookName = bo.Name,
        //             } ).ToList();
        // }
        // public void DeletAuthor(int id) 
        //{

        //     var delete=_context.Authors.Where(_=>_.Id==id).First();
        //     if (delete == null)
        //     {
        //         throw new Exception();
        //     }
        //     _context.Authors.Remove(delete);
        //     _context.SaveChanges();

        // }

    }
}
