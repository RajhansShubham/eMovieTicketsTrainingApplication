using eMovieTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _appContext;

        public CinemaController(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<IActionResult> Index()
        {
            var cinemas = await _appContext.Cinemas.ToListAsync();
            return View();
        }
    }
}
