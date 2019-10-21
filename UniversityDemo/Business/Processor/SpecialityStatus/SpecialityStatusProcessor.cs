using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.SpecialityStatus;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Processor.SpecialityStatus
{
    public class SpecialityStatusProcessor: ISpecialityStatusProcessor
    {
        public ISpecialityStatusDao Dao { get; set; }

        public ISpecialityStatusParamConverter ParamConverter { get; set; }

        public ISpecialityStatusResultConverter ResultConverter { get; set; }

        public SpecialityStatusProcessor(ISpecialityStatusDao dao,
            ISpecialityStatusParamConverter paramConverter,
            ISpecialityStatusResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public SpecialityStatusResult Create(SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<SpecialityStatusResult> Create(List<SpecialityStatusParam> param)
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

        public SpecialityStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<SpecialityStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, SpecialityStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<SpecialityStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
