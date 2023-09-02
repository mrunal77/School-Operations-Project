using Microsoft.EntityFrameworkCore;
using School_Api_Project.Entity.Models;


namespace School_Api_Project.DbContextDirectory
{
    public class MTSchool_DbContext : DbContext
    {
        public MTSchool_DbContext(DbContextOptions<MTSchool_DbContext> options) : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staff { get; set; }

    }
}