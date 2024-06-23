using Microsoft.EntityFrameworkCore;
using OrganicAtelier.DAL.Abstract;
using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Concrete.EfCore
{
    public class EfCoreContactDal : IContactDal
    {
        public Contact GetOne()
        {
            using (var context = new DataContext())
            {
                return context.Contacts.FirstOrDefault();
            }
        }

        public void Update(Contact entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
