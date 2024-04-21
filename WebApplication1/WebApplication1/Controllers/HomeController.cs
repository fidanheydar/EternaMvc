using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {


        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                Slides = _context.Slides.OrderByDescending(x => x.Order).ToList(),
                Clients = _context.Clients.ToList(),
                Features = _context.Features.ToList()
            };
            return View(viewModel);
        }
    }

}
