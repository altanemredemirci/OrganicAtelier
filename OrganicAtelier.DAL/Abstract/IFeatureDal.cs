using AutoMapper.Features;
using OrganicAtelier.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganicAtelier.DAL.Abstract
{
    public interface IFeatureDal
    {
        List<Feature> GetAll();
        void Update(Feature entity);
    }
}