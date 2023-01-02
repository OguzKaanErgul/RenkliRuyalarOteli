using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMVCUI.Areas.Admin.Controllers
{
    public class OdaFiyatController : Controller
    {
        private readonly IOdaFiyatManager odaFiyatManager;

        public OdaFiyatController(IOdaFiyatManager odaFiyatManager)
        {
            this.odaFiyatManager = odaFiyatManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
