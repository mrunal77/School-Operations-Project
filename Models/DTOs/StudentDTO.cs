namespace School_Api_Project.Models.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ClassID { get; set; }
    }
}
