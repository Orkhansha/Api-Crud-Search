using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Book
{
    public class BookCreateDto
    {
        public string? Name { get; set; }
        public int PageCount { get; set; }
        public string? Author { get; set; }
    }
}
