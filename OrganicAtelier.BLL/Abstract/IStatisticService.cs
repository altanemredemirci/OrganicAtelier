using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.Abstract
{
    public interface IStatisticService
    {
        int ProductTypesCount();
        int ActiveProductTypeCount();
        int ProductCount();
        decimal AvgProductWeight();
        decimal AvgProductPrice();
        decimal CheapestProduct();
        decimal TheMostExpensiveProduct();
        decimal LastProductPrice();     
    }
}
