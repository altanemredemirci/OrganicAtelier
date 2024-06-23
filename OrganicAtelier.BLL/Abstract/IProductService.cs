using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.Abstract
{
    public interface IProductService:IRepositoryService<Product>
    {
		List<Product> GetPopularAll();
        List<Product> Last5Product();
    }
}
