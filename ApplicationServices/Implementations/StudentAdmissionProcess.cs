using School_Api_Project.Entity.Models;
using School_Api_Project.Models.DTOs;
using School_Api_Project.UnitOfWork_Configuration.Interface;

namespace School_Api_Project.ApplicationServices.Implementations
{
    public class StudentAdmissionProcess : IStudentAdmissionProcess
    {
        private IUnitOfWork _unitOfWork;
        public StudentAdmissionProcess(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public StudentDTO StudentAdd(StudentDTO student)
        {
            var data = _unitOfWork.StudentClass.Get(student.ClassID);
            Student student1 = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                FullName = student.FirstName + " " + student.LastName,
                ClassID = student.ClassID,
                StudentClass = data.Result,
            };

            _unitOfWork.Students.Add(student1);
            _unitOfWork.Complete();

            student.FullName = student1.FullName;
            student.Id = student1.Id;

            return student;
        }
    }
}
