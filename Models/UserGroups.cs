using System.ComponentModel.DataAnnotations.Schema;

namespace eDziennikv2.Models
{
    public class UserGroups
    {
        public string Id { get; set; }

        //public virtual ApplicationUser User { get; set; }
        //public virtual Groups Group { get; set;}
        [ForeignKey("AspNetUsers")]
        public string UserId { get; set; }
        [ForeignKey("Groups")]
        public string GroupId { get; set; }
    }
}
