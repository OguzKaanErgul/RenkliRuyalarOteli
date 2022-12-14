using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMVCUI.Controllers
{
    public class RezervasyonDatayController : Controller
    {
        private readonly IRezervasyonDetayManager rezervasyonDetayManager;

        public RezervasyonDatayController(IRezervasyonDetayManager rezervasyonDetayManager)
        {
            this.rezervasyonDetayManager = rezervasyonDetayManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
