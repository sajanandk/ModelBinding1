﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        
        public string Name { get; set; }
        
        public string LastName { get; set; }

        public string Email { get; set; }
        public string City { get; set; }
    }
}