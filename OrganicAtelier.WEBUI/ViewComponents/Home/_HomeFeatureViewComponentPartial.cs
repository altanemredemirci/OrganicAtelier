using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.FeatureDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Home
{
    public class _HomeFeatureViewComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public _HomeFeatureViewComponentPartial(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ResultFeatureDTO>>(_featureService.GetAll()));
        }
    }
}
