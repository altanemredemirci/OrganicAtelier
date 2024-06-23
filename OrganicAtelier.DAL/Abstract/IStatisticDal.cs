using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Abstract
{
    public interface IStatisticDal
    {
        int ProductTypesCount();
        int ActiveProductTypeCount();
        int ProductCount();
        decimal AvgProductPrice();
        decimal AvgProductWeight();
        decimal CheapestProduct();
        decimal TheMostExpensiveProduct();
        decimal LastProductPrice();
    }
}
