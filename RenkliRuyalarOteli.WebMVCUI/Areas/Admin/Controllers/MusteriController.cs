using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RenkliRuyalarOteli.BL.Abstract;
using RenkliRuyalarOteli.WebMVCUI.Areas.Admin.Models.Musteri;

namespace RenkliRuyalarOteli.WebMVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class MusteriController : Controller
    {
        private readonly IMusteriManager musteriManager;

        public MusteriController(IMusteriManager musteriManager)
        {
            this.musteriManager = musteriManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await musteriManager.FindAllIncludeAsync();
            return View(result.ToList());
        }

        public async Task<IActionResult> Update(Guid Id)
        {
            var musteri = musteriManager.FindAsync(p => p.Id == Id).Result;
            MusteriUpdateDTO musteriUpdateDTO = new MusteriUpdateDTO()
            {
                Ad = musteri.Ad,
                Soyad = musteri.Soyad,
                Cinsiyet = musteri.Cinsiyet,
                MusteriTcNo = musteri.MusteriTcNo,
                CepNo = musteri.CepNo
            };
            return View(musteriUpdateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {

            var createDto = new MusteriCreateDTO();


            return View(createDto);
        }
    }
}
