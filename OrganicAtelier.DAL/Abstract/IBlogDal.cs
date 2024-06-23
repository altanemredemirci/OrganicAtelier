using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Abstract
{
    public interface IBlogDal
    {
        List<Blog> GetAll();
        void Update(Blog blog);
    }
}
