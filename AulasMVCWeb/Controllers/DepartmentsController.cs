﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AulasMVCWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulasMVCWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            return View(list);
        }

        public IActionResult Create(String Name, int Id)
        {
            
            return View();
        }
    }
}