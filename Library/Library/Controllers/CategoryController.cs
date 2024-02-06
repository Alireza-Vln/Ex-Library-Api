using Library.DTO;
using Library.Entites;
using Library.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Controller]
    [Route("Api/Category")]
    public class CategoryController : Controller
    {
        private readonly CategoryService _service;
        public CategoryController()
        {
            _service= new CategoryService();
        }

        [HttpPost("add-category/{i}")]

        public int AddCategory([FromRoute]int i,[FromBody]AddCategoryDto dto)
        {
            return _service.AddCategory(i,dto);
        }
        [HttpGet("serch-Book/{serche}")]
        public Book SerchBook([FromRoute]string serche)
        {
            return _service.SerchCategory(serche);
        }
    }
}
