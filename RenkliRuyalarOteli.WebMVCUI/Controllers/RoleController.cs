using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;

namespace RenkliRuyalarOteli.WebMVCUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleManager roleManager;
        public RoleController(IRoleManager roleManager)
        {
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
