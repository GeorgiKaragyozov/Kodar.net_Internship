using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Speciality;

namespace UniversityDemo.Business.Processor.Speciality
{
    public interface ISpecialityProcessor
    {
        SpecialityResult Create(SpecialityParam param);
        List<SpecialityResult> Create(List<SpecialityParam> param);

        void Update(long id, SpecialityParam param);
        void Update(List<SpecialityParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        SpecialityResult Find(long id);
        List<SpecialityResult> Find();
    }
}
