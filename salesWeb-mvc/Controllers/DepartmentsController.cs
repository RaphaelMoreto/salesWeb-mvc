﻿using Microsoft.AspNetCore.Mvc;
using salesWeb_mvc.Models;

namespace salesWeb_mvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletrônicos" });
            list.Add(new Department { Id = 2, Name = "Moda" });

            return View();
        }
    }
}