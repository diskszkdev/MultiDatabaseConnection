using MultiDatabaseApp.Models.CompanyDatabase;
using MultiDatabaseApp.Models.SchoolDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiDatabaseApp.Models
{
    public static class DbInitializer
    {
        public static void Initialize(CompanyContext companyContext, SchoolContext schoolContext)
        {
            companyContext.Database.EnsureCreated();
            schoolContext.Database.EnsureCreated();

            if (companyContext.Employees.Any() == false)
            {
                var employees = new Employee[]
                {
                    new Employee{Name="aaa",Email="aaa@aaa",Age=20},
                    new Employee{Name="bbb",Email="bbb@bbb",Age=20}
                };

                companyContext.Employees.AddRange(employees);
                companyContext.SaveChanges();
            }



            if (schoolContext.Students.Any() == false)
            {
                var students = new Student[]
                {
                    new Student{FirstName="AAA",LastName="AAA",Address="AAA"},
                    new Student{FirstName="BBB",LastName="BBB",Address="BBB"},
                    new Student{FirstName="CCC",LastName="CCC",Address="CCC"},
                };

                schoolContext.Students.AddRange(students);
                schoolContext.SaveChanges();
            }
        }
    }
}
