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
            var result = _toDoService.GetAll();
            return View(result);
        }

        public IActionResult Completed()
        {
            var result = _toDoService.GetAllCompleted();
            return View();
        }

        public IActionResult Current(int id)
        {
            var result = _toDoService.GetIncompleteForUser(id);
            return View();
        }
    }
}