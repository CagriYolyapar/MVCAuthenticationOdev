using MVCAuthentication_0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuthentication_0.ViewModels
{
    public class EmployeeVM
    {
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }

    }
}