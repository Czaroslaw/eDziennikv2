using Microsoft.Build.Framework;

namespace eDziennikv2.Models
{
    public class Subjects
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string Name { get; set; }
    }
}
