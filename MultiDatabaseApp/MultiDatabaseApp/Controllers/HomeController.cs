using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiDatabaseApp.Models;
using MultiDatabaseApp.Models.CompanyDatabase;
using MultiDatabaseApp.Models.SchoolDatabase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MultiDatabaseApp.Controllers
{
    public class HomeController : Controller
    {
        private CompanyContext _companyContext;
        private SchoolContext _schoolContext;

        public HomeController(CompanyContext companyContext, SchoolContext schoolContext)
        {
            _companyContext = companyContext;
            _schoolContext = schoolContext;
        }

        public IActionResult Index()
        {
            var employees = _companyContext.Employees.ToList();
            var students = _schoolContext.Students.ToList();

            var vm = new ResultViewModel
            {
                Employees = employees,
                Students = students
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
