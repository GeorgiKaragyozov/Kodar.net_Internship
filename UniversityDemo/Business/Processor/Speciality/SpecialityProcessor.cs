using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Speciality;
using UniversityDemo.DataAccess.DataAccessObject.Speciality;

namespace UniversityDemo.Business.Processor.Speciality
{
    public class SpecialityProcessor : ISpecialityProcessor
    {
        public SpecialityDao Dao { get; set; }

        public SpecialityParamConverter ParamConverter { get; set; }

        public SpecialityResultConverter ResultConverter { get; set; }

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
