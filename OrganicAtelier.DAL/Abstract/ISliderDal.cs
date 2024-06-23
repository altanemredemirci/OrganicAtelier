using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Abstract
{
    public interface ISliderDal
    {
        List<Slider> GetAll(Expression<Func<Slider, bool>> filter);
        Slider GetOne(Expression<Func<Slider, bool>> filter);
        Slider GetById(int id);

        void Update(Slider entity);
        void Create(Slider entity);
        void Delete(Slider entity);
    }
}
