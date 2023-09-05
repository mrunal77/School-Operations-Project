
using School_Api_Project.Entity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Api_Project.Models
{
    public class StudentClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public List<Student> students { get; set; } = new List<Student>();
        public Staff CLassTeacher { get; set; } = null!;
    }
}
