using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandsController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
