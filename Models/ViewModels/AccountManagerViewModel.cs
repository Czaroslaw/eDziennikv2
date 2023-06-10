using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eDziennikv2.Models.ViewModels
{
    [ValidateNever]
    public class AccountManagerViewModel
    {
        public virtual ApplicationUser User { get; set; }
        //public virtual ApplicationUser Parent { get; set; }
        public virtual Groups Group { get; set; }
        public virtual UserGroups UserGroup { get; set; }
        public List<SelectListItem> AvailableGroupList { get; set; }
    }
}
