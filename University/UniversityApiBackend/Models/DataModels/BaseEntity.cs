using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string CreatedBy { get; set; } = string.Empty; // Por defecto NULL.

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string UpdatedBy { get; set; } = string.Empty;

        public DateTime? UpdatedAt { get; set; }

        public string DeletedBy { get; set; } = string.Empty;

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
