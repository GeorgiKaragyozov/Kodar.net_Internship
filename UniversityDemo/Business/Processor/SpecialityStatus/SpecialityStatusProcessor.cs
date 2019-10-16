using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.SpecialityStatus;
using UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus;

namespace UniversityDemo.Business.Processor.SpecialityStatus
{
    public class SpecialityStatusProcessor: ISpecialityStatusProcessor
    {
        public SpecialityStatusDao Dao { get; set; }

        public SpecialityStatusParamConverter ParamConverter { get; set; }

        public SpecialityStatusResultConverter ResultConverter { get; set; }

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
