using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService = new DataService();

        [HttpGet("")]
        public IActionResult Index()
        {
            Band[] bands = dataService.GetAllBands();
            return View(bands);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            Band bandById = dataService.GetBandById(id);
            return View(bandById);
        }
    }
}
