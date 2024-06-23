using Microsoft.AspNetCore.Mvc;
using OrganicAtelier.BLL.Abstract;

namespace OrganicAtelier.WEBUI.Controllers
{
    public class StatisticController : Controller
    {

        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }

        public IActionResult Index()
        {
            ViewBag.ProductTypeCount = _statisticService.ProductTypesCount();
            ViewBag.ActiveProductTypeCount = _statisticService.ActiveProductTypeCount();
            ViewBag.ProductCount = _statisticService.ProductCount();
            ViewBag.AvgProductPrice = _statisticService.AvgProductPrice();
            ViewBag.AvgProductWeight = _statisticService.AvgProductWeight();
            ViewBag.LastProductPrice = _statisticService.LastProductPrice();
            ViewBag.TheMostExpensiveProduct = _statisticService.TheMostExpensiveProduct();
            ViewBag.CheapestProduct = _statisticService.CheapestProduct();
            return View();
        }
    }
}
