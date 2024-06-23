using AutoMapper;
using OrganicAtelier.BLL.Abstract;
using OrganicAtelier.BLL.DTOs.BlogDTO;
using OrganicAtelier.DAL.Abstract;
using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.BLL.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }
    }
}
