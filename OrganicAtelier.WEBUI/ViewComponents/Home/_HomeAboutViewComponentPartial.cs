using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.AboutDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Home
{
    public class _HomeAboutViewComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public _HomeAboutViewComponentPartial(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var about = _aboutService.GetOne();
            var model = _mapper.Map<ResultAboutDTO>(about);
            return View(model);
        }
    }
}
