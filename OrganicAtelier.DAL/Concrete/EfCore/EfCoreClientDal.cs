using Microsoft.EntityFrameworkCore;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Concrete.EfCore
{
    public class EfCoreClientDal : EfCoreGenericRepository<Client, DataContext>, IClientDal
    {
     
    }
}
