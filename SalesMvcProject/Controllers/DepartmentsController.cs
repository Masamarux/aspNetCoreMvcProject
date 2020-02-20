using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesMvcProject.Models;

namespace SalesMvcProject.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> listD = new List<Department>();
            listD.Add(new Department { Id = 1, Name = "Electronics" });
            listD.Add(new Department { Id = 2, Name = "Fashion" });
            listD.Add(new Department { Id = 3, Name = "Food" });

            return View(listD);
        }
    }
}