using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.ViewModels
{
    public class EmployDeparmentViewModel
    {
        public Employ Employ { get; set; }
        public Department Department { get; set; }
        public List<Department> Departments { get; set; }
    }
}