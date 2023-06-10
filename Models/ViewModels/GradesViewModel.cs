using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace eDziennikv2.Models.ViewModels
{
    public class GradesViewModel
    {
        [Required]
        public string Description { get; set; }
        public int Grade { get; set; }
        public string SubjectId { get; set; }
        public List<SelectListItem> Grades { get; set; }
        public List<SelectListItem> Subjects { get; set; }
        public string StudentId { get; set; }
    }
}
