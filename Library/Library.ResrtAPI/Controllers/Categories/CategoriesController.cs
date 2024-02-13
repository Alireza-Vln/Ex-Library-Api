using Library.DTO;
using Library.Services;
using Library.Services.Categories.Cantract;
using Microsoft.AspNetCore.Mvc;

namespace Library.ResrtAPI.Controllers.Categories
{
    [ApiController]
    [Route("Api/Category")]
    public class CategoriesController : Controller
    {
        readonly CaregoryService _service;
        public CategoriesController(CaregoryService service)
        {
            _service = service;
        }
        [HttpPost("Add-Category/{id}")]
        public async Task AddCategory(AddCategoryDto dto ,int id)
        {
            await _service.AddCategory(dto, id);
        }
    }
}
