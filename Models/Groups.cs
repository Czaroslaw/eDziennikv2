using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace eDziennikv2.Models
{
    public class Groups
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
