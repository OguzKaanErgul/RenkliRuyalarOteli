using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMVCUI.Controllers
{
    public class OdaController : Controller
    {
        private readonly IOdaManager odaManager;

        public OdaController(IOdaManager odaManager)
        {
            this.odaManager = odaManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
