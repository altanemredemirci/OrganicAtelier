using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Abstract
{
    public interface IAboutDal
    {
        About GetOne(Expression<Func<About, bool>> filter = null);
        void Update(About entity);
    }
}
