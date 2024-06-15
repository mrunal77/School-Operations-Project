using Microsoft.AspNetCore.Mvc;
using School_Api_Project.ApplicationServices;
using School_Api_Project.Entity.Models;
using School_Api_Project.Models.DTOs;
using School_Api_Project.UnitOfWork_Configuration.Interface;

namespace School_Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentAdmissionProcess _studentAdmissionProcess;
        public StudentController(IUnitOfWork unitOfWork, IStudentAdmissionProcess studentAdmissionProcess)
        {
            _unitOfWork = unitOfWork;
            _studentAdmissionProcess = studentAdmissionProcess;
        }


        // GET: api/<Books>
        [HttpGet(nameof(GetStudents))]
        public async Task<IActionResult> GetStudents() => Ok(await _unitOfWork.Students.GetAll());

        [HttpGet(nameof(GetStudentByName))]
        public async Task<IActionResult> GetStudentByName([FromQuery] string studentFirstName) => Ok(await _unitOfWork.Students.GetStudentsByStudentName(studentFirstName));

        [HttpPost(nameof(AddStudent))]
        public IActionResult AddStudent([FromBody] StudentDTO student)
        {
            var studentRet = _studentAdmissionProcess.StudentAdd(student);
            //var studentData = _unitOfWork.Students.Add(student);
            //_unitOfWork.Complete();
            return Ok(studentRet);
        }
    }
}
