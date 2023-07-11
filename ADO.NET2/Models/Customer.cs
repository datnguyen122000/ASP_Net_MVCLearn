using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADO.NET.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int IdCustomerType { get; set; }
    }
}