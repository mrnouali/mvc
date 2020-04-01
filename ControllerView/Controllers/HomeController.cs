using System.Linq;
using System.Security.Principal;
using ControllerView.Models;
using ControllerView.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ControllerView.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Tasks = _context.Tasks.ToList()
            };
            return View(viewModel);
        }
    }
}