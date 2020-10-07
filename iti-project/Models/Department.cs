using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iti_project.Models
{
    public class Department
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}