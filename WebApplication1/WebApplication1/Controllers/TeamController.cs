using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var iconElement = _context.Teams.Include(x => x.TeamIcons).ToList();
            return View(iconElement);
        }
    }
}
