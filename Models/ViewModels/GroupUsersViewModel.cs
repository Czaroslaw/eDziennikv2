namespace eDziennikv2.Models.ViewModels
{
    public class GroupUsersViewModel
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
