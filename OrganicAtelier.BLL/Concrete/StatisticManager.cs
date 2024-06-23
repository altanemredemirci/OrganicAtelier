using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStatisticDal _statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        public int ActiveProductTypeCount()
        {
            return _statisticDal.ActiveProductTypeCount();
        }

        public decimal AvgProductPrice()
        {
            return _statisticDal.AvgProductPrice();

        }

        public decimal AvgProductWeight()
        {
            return _statisticDal.AvgProductWeight();
        }

        public decimal CheapestProduct()
        {
            return _statisticDal.CheapestProduct();
        }

        public decimal LastProductPrice()
        {
            return _statisticDal.LastProductPrice();
        }

        public int ProductCount()
        {
            return _statisticDal.ProductCount();
        }

        public int ProductTypesCount()
        {
            var m = _statisticDal.ProductTypesCount();
            return m;
        }

        public decimal TheMostExpensiveProduct()
        {
            return _statisticDal.TheMostExpensiveProduct();
        }
    }
}
