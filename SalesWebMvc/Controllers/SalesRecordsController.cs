﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult SimpleSearch()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
