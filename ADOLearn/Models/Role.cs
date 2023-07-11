using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLearn.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public virtual ICollection<Employee_Role> Employee_Role { get; set; }
    }
}