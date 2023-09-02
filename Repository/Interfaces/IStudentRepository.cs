using School_Api_Project.Entity.Models;

namespace School_Api_Project.Repository.Interfaces
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
       Task<IEnumerable<Student>> GetStudentsByStudentName(string studentName);
    }
}