using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.ProductDTO;

namespace OrganicAtelier.WEBUI.ViewComponents.Home
{
	public class _HomePopularProductViewComponentPartial : ViewComponent
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public _HomePopularProductViewComponentPartial(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

		public IViewComponentResult Invoke()
		{
			return View(_mapper.Map<List<ResultProductDTO>>(_productService.GetPopularAll()));
		}
	}
}
