using Microsoft.EntityFrameworkCore;

namespace School_Api_Project.Models
{
    [PrimaryKey(nameof(CategoryId))]
    public class BookCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Book> BookId { get; set; }
    }
}