using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLearn.Models
{
    public class Employee_Role
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public string Note { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}