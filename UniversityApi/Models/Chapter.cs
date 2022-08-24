using System.ComponentModel.DataAnnotations;

namespace UniversityApi.Models
{
    public class Chapter : BaseEntity
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();

        [Required]
        public string Chapters { get; set; } = string.Empty;
    }
}