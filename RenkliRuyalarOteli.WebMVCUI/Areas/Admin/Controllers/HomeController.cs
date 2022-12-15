using Microsoft.AspNetCore.Mvc;

namespace RenkliRuyalarOteli.WebMVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
