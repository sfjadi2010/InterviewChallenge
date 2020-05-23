using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewChallenge.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewChallenge.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }
        
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