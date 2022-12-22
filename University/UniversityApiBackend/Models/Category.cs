using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models
{
    public class Category
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
