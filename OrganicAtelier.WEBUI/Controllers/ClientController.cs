using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ClientDTO;
using OrganicAtelier.BLL.DTOs.SliderDTO;
using OrganicAtelier.Entity;
using OrganicAtelier.WEBUI.Models;

namespace OrganicAtelier.WEBUI.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var client = _clientService.GetAll();

            return View(_mapper.Map<List<ResultClientDTO>>(client));
        }

        public IActionResult Edit(int id)
        {
            var client = _clientService.GetById(id);

            return View(_mapper.Map<UpdateClientDTO>(client));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateClientDTO dto, IFormFile file)
        {
            ModelState.Remove("ImageUrl");
            if (ModelState.IsValid)
            {
                var client = _clientService.GetById(dto.Id);

                if (client == null)
                {
                    ErrorViewModel error = new ErrorViewModel()
                    {
                        Code = 404,
                        Title = "Client Bulunamadı",
                        Description = "Lütfen seçiminizi kontrol ediniz.",
                        ReturnUrl = "/Slider/Index",
                        Css = "text-danger"
                    };
                    return View("Error", error);
                }

                if (file != null)
                {                   
                    dto.ImageUrl = await ImageMethods.UploadImage(file);
                }                              

                _clientService.Update(_mapper.Map<Client>(dto));
                return RedirectToAction("Index");
            }

            return View(dto);
        }
    }
}
