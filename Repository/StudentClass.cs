using School_Api_Project.DbContextDirectory;
using School_Api_Project.Models;
using School_Api_Project.Repository.Interfaces;

namespace School_Api_Project.Repository
{
    public class StudentClassRepository : GenericRepository<StudentClass>, IStudentClassRepository
    {
        public StudentClassRepository(MTSchool_DbContext context) : base(context)
        {

        }
    }
}
