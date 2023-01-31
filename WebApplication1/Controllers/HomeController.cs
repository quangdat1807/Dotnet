using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Models.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TodoCreate(Todo todo)
        {
            if (ModelState.IsValid)
            {
                TodoRepository.AddTodo(todo);
                return View(todo);
            }
            else
            {
                return View("TodoCreate");
            }
          
        }
        public IActionResult TodoList()
        {
            return View(TodoRepository.GetTodos());
        }
    }
}