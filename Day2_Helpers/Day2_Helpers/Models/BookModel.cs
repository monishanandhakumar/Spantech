using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2_Helpers.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int TotalPages { get; set; }
        public string Description { get; set; }
        public List<string> Booktype { get; set; }
    }
}
