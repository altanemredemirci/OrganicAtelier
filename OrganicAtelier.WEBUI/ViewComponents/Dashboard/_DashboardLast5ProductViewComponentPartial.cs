using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ProductDetailDTO;
using OrganicAtelier.BLL.DTOs.ProductDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Dashboard
{
    public class _DashboardLast5ProductViewComponentPartial: ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _DashboardLast5ProductViewComponentPartial(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.Last5Product();

            return View(_mapper.Map<List<ResultProductDTO>>(products));
        }
    }
}
