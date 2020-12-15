using MultiDatabaseApp.Models.CompanyDatabase;
using MultiDatabaseApp.Models.SchoolDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiDatabaseApp.Models
{
    public class ResultViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<Student> Students { get; set; }
    }
}
