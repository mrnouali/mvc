using ControllerView.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerView.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}