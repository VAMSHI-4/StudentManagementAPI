namespace StudentManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Email { get; set; }

        public string? Course { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
