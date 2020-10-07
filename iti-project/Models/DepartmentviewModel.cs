using System.Collections.Generic;

namespace iti_project.Models
{
    public class DepartmentviewModel
    {
        public Department Department { get; set; }
        public IList<Department> Departments { get; set; }
    }
}