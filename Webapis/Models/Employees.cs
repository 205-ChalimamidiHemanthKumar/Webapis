using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapis.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
    }
}
