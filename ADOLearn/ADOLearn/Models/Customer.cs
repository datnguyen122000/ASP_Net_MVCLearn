﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADOLearn.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}