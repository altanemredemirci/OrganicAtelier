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
    public class EfCoreAboutDal : IAboutDal
    {
        public About GetOne(Expression<Func<About, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return filter == null
                    ? context.Abouts.FirstOrDefault()
                    : context.Abouts.FirstOrDefault(filter);
            }
        }

        public void Update(About entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
