using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ProductDTO;
using OrganicAtelier.DAL.Abstract;

namespace OrganicAtelier.WEBUI.ViewComponents.Home
{
    public class _HomeProductViewComponentPartial : ViewComponent
    {

        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _HomeProductViewComponentPartial(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.GetAll(i => i.Status == true);

            var resultProducts = _mapper.Map<List<ResultProductDTO>>(products);
            return View(resultProducts);
        }
    }
}
