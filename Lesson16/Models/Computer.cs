﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson16.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int YearOfManufacture { get; set; }
    }
}