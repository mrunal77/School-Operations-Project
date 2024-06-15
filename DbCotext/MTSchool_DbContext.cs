using Microsoft.EntityFrameworkCore;
using School_Api_Project.Entity.Models;
using School_Api_Project.Models;

namespace School_Api_Project.DbContextDirectory
{
    public class MTSchool_DbContext : DbContext
    {
        public MTSchool_DbContext(DbContextOptions<MTSchool_DbContext> options) : base(options)
        { }

        public DbSet<Student> students { get; set; }
        public DbSet<Staff> staff { get; set; }
        public DbSet<StudentClass> studentClasses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategory { get; set; }

    }
}