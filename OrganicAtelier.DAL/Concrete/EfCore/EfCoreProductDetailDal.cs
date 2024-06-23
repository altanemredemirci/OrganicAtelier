using Microsoft.EntityFrameworkCore;
using OrganicAtelier.DAL.Abstract;
using OrganicAtelier.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Concrete.EfCore
{
    public class EfCoreProductDetailDal : EfCoreGenericRepository<ProductDetail, DataContext>, IProductDetailDal
    {
        public override ProductDetail GetById(int id)
        {
            using (var context = new DataContext())
            {
                var model = context.ProductDetail.Where(i => i.ProductId == id).Include(i => i.Product).ThenInclude(i => i.ProductType).FirstOrDefault();

                return model;
            }
        }

    }
}
