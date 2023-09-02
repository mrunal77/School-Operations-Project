using System.ComponentModel.DataAnnotations;

namespace School_Api_Project.Entity.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}