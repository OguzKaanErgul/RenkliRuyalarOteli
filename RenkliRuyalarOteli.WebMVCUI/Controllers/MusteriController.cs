using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMVCUI.Controllers
{
    public class MusteriController : Controller
    {
        private readonly IMusteriManager musteriManager;

        public MusteriController(IMusteriManager musteriManager)
        {
            this.musteriManager = musteriManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
