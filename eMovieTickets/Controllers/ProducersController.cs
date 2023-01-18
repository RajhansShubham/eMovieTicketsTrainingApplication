using eMovieTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _appContext;

        public ProducersController(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _appContext.Producer.ToListAsync();
            return View();
        }
    }
}
