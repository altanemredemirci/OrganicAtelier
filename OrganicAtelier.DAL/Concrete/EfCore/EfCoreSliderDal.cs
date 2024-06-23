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
    public class EfCoreSliderDal : ISliderDal
    {
        public void Create(Slider entity)
        {
            using (var context = new DataContext())
            {
                context.Sliders.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Slider entity)
        {
            using (var context = new DataContext())
            {
                context.Sliders.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<Slider> GetAll(Expression<Func<Slider, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return filter == null
                    ? context.Sliders.ToList()
                    : context.Sliders.Where(filter).ToList();
            }
        }

        public Slider GetById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Sliders.Find(id);
            }
        }

        public Slider GetOne(Expression<Func<Slider, bool>> filter)
        {
            using (var context = new DataContext())
            {
                return context.Sliders.FirstOrDefault(filter);
            }
        }

        public void Update(Slider entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
