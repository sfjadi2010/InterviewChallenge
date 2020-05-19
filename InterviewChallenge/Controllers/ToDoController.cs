using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewChallenge.Controllers
{
    public class ToDoController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }

        public IActionResult Current(int id)
        {
            return View();
        }
    }
}