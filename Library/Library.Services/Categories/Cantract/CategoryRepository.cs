using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Categories.Cantract
{
    public interface CategoryRepository
    {
        void AddCategory(Entites.Category category,int i);
        void DeleteCategory(int id); 
    }
}
