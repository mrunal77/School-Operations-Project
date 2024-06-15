using Microsoft.EntityFrameworkCore;
using School_Api_Project.Entity.Models;

namespace School_Api_Project.Models
{
    [PrimaryKey(nameof(BookId))]
    public class Book
    {        
        public int BookId { get; set; }
        public string BookName { get; set; }
        public BookCategory Category { get; set; }
    }
}
