using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMVCUI.Controllers
{
    public class RezervasyonController : Controller
    {
        private readonly IRezervasyonManager rezervasyonManager;

        public RezervasyonController(IRezervasyonManager rezervasyonManager)
        {
            this.rezervasyonManager = rezervasyonManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
