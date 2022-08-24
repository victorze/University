using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApi.Models
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int CreatedById { get; set; }
        [ForeignKey("CreatedById")]
        public virtual User CreatedBy { get; set; } = new User();

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int UpdatedById { get; set; }
        [ForeignKey("UpdatedById")]
        public virtual User UpdatedBy { get; set; } = new User();

        public DateTime? UpdatedAt { get; set; }

        public int DeletedBId { get; set; }
        [ForeignKey("DeletedBId")]
        public virtual User DeletedBy { get; set; } = new User();

        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
