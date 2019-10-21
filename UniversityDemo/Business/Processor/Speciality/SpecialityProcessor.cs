using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Processor.Speciality
{
    public class SpecialityProcessor : ISpecialityProcessor
    {
        public ISpecialityDao Dao { get; set; }

        public ISpecialityParamConverter ParamConverter { get; set; }

        public ISpecialityResultConverter ResultConverter { get; set; }

        public SpecialityProcessor(ISpecialityDao dao, ISpecialityParamConverter paramConverter,
            ISpecialityResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public SpecialityResult Create(SpecialityParam param)
        {
            throw new NotImplementedException();
        }

        public List<SpecialityResult> Create(List<SpecialityParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public SpecialityResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<SpecialityResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, SpecialityParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<SpecialityParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
