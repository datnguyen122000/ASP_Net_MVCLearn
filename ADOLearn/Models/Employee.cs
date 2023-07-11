using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLearn.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmployeeName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBird { get; set; }
        public string Address { get; set; }
        public int? IdEmployeeType { get; set; }
        public string Position { get; set; }
        public virtual ICollection<Employee_Role> Employee_Role { get; set; }
    }
}