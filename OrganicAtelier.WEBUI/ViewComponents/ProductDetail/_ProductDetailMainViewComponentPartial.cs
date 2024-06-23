using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ProductDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.ProductDetail
{
    public class _ProductDetailMainViewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _ProductDetailMainViewComponentPartial(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke(int id)
        {
            var product = _productService.GetById(id);
            return View(_mapper.Map<ResultProductDTO>(product));
        }
    }
}

