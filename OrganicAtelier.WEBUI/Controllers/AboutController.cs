using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using OrganicAtelier.BLL;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.AboutDTO;
using OrganicAtelier.Entity;
using OrganicAtelier.WEBUI.Models;

namespace OrganicAtelier.WEBUI.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var about = _aboutService.GetOne();
            return View(_mapper.Map<ResultAboutDTO>(about));
        }

        public IActionResult Edit(int id)
        {
            var whoWeAre = _aboutService.GetOne();
            return View(_mapper.Map<UpdateAboutDTO>(whoWeAre));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateAboutDTO dto, IFormFile file)
        {
            ModelState.Remove("Image");
            if (ModelState.IsValid)
            {
                var about = _aboutService.GetOne();

                if (about == null)
                {
                    ErrorViewModel error = new ErrorViewModel()
                    {
                        Code = 404,
                        Title = "Slider Bulunamadı",
                        Description = "Lütfen seçiminizi kontrol ediniz.",
                        ReturnUrl = "/About/Index",
                        Css = "text-danger"
                    };
                    return View("Error", error);
                }

                if (file != null)
                {
                    if (about.Image != null)
                    {
                        ImageMethods.DeleteImage(about.Image);
                    }

                    dto.Image = await ImageMethods.UploadImage(file);
                }

                _aboutService.Update(_mapper.Map<About>(dto));
                return RedirectToAction("Index");
            }

            return View(dto);
        }
    }
}
