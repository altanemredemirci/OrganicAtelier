using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.Abstract
{
    public interface IAboutService
    {
        About GetOne(Expression<Func<About, bool>> filter = null);
        void Update(About entity);
    }
}
