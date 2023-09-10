using School_Api_Project.Models.DTOs;

namespace School_Api_Project.ApplicationServices
{
    public interface IStudentAdmissionProcess
    {
        public StudentDTO StudentAdd(StudentDTO student);
       
    }
}
