using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLearn.Models
{
    public class CustomerType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}