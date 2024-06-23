using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.BlogDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Home
{
    public class _HomeBlogViewComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public _HomeBlogViewComponentPartial(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ResultBlogDTO>>(_blogService.GetAll()));
        }
    }
}