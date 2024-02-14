using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Categories.Cantract
{
    public interface CaregoryService
    {
        public Task AddCategory(AddCategoryDto dto,int i);
        public Task DeleteCategory(int id);
    }
}
