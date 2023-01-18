using eMovieTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _appContext;

        public MoviesController(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<IActionResult> Index()
        {
            var cinemas = await _appContext.Movies.ToListAsync();
            return View();
        }
    }
}
