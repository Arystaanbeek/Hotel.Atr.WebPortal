using Microsoft.AspNetCore.Mvc;

namespace Hotel.Atr.WebPortal.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
