using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Abstract
{
    public interface IContactDal
    {
        Contact GetOne();
        void Update(Contact entity);
    }
}
