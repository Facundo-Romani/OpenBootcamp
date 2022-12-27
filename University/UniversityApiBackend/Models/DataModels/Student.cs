using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; } 

        [Required]
        public DateTime Dob { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
