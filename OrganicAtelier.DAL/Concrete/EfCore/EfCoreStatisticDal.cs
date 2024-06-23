using OrganicAtelier.DAL.Abstract;
using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Concrete.EfCore
{
    public class EfCoreStatisticDal : IStatisticDal
    {
        public int ActiveProductTypeCount()
        {
            using (var context = new DataContext())
            {
                return context.ProductTypes.Where(i => i.Status == true).Count();
            }
        }

        public decimal AvgProductPrice()
        {
            using (var context = new DataContext())
            {
                var avaragePrice = context.Products.Average(e => e.Price);

                return Math.Round(avaragePrice, 2);
            }
        }

        public decimal AvgProductWeight()
        {
            using (var context = new DataContext())
            {
                var averageWeight = context.Products.Average(e => e.Weight);
                return Math.Round(averageWeight, 2);
            }
        }

        public decimal CheapestProduct()
        {
            using (var context = new DataContext())
            {
                return context.Products.Min(i => i.Price);
            }
        }

        public decimal LastProductPrice()
        {
            using (var context = new DataContext())
            {
                return context.Products.OrderByDescending(i => i.Id).Select(i => i.Price).FirstOrDefault();
            }
        }

        public int ProductCount()
        {
            using (var context = new DataContext())
            {
                return context.Products.Count();
            }
        }

        public int ProductTypesCount()
        {
            using (var context = new DataContext())
            {
                return context.ProductTypes.Count();
            }
        }

        public decimal TheMostExpensiveProduct()
        {
            using (var context = new DataContext())
            {
                return context.Products.OrderByDescending(i => i.Price).Select(i => i.Price).FirstOrDefault();
            }
        }
    }
}
