using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Authors.Cantract.Dtos
{
    public class GetAuthorDto
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }  
        public string BookName { get; set; }
    }
}
