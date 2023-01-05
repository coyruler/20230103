﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        public readonly NorthwindContext _context = null;
        public AjaxController(NorthwindContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string Greet(string Name)
        {
            Thread.Sleep(3000);
            return $"Hello: {Name}";
        }
        [HttpPost(),ActionName("Greet")]
        public string PostGreet(string Name)
        {
            return $"Hello, {Name}";
        }

        [HttpPost]
        public string CheckName(string CompanyName)
        {
            bool Exists = _context.Customers.Any(c => c.CompanyName == CompanyName);
            return Exists ? "true" : "false" ;
        }

    }
}
