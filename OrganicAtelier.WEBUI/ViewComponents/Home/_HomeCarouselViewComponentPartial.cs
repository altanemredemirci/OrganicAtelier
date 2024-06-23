using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.SliderDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Home
{
    public class _HomeCarouselViewComponentPartial : ViewComponent
    {
        private readonly ISliderService _sliderService;        
        private readonly IMapper _mapper;

        public _HomeCarouselViewComponentPartial(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }



        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<ResultSliderDTO>(_sliderService.GetOne(i => i.Page == "Index")));
        }
    }
}
