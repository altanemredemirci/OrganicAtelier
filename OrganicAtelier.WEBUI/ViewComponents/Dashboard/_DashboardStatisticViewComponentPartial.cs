using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;

namespace OrganicAtelier.WEBUI.ViewComponents.Dashboard
{
	public class _DashboardStatisticViewComponentPartial : ViewComponent
	{
		private readonly IStatisticService _statisticService;

		public _DashboardStatisticViewComponentPartial(IStatisticService statisticService)
		{
			_statisticService = statisticService;
		}

		public IViewComponentResult Invoke()
		{
			ViewBag.ProductCount = _statisticService.ProductCount();
			ViewBag.ProductTypesCount = _statisticService.ProductTypesCount();
			ViewBag.AvgProductPrice = _statisticService.AvgProductPrice();
			ViewBag.LastProductPrice = _statisticService.LastProductPrice();
			return View();
		}
	}
}
