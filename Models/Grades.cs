using System.ComponentModel.DataAnnotations;

namespace eDziennikv2.Models
{
    public class Grades
    {
        public string Id { get; set; }  = Guid.NewGuid().ToString();
        [Required]
        public string Description { get; set; }
        public int Grade { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public virtual Subjects Subject { get; set; }
        public virtual ApplicationUser IssuedBy { get; set; }
        public virtual ApplicationUser IssuedTo { get; set; }
    }
}
