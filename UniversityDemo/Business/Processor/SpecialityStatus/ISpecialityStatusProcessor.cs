using System.Collections.Generic;
using UniversityDemo.Business.Convertor.SpecialityStatus;

namespace UniversityDemo.Business.Processor.SpecialityStatus
{
    public interface ISpecialityStatusProcessor
    {
        SpecialityStatusResult Create(SpecialityStatusParam param);
        List<SpecialityStatusResult> Create(List<SpecialityStatusParam> param);

        void Update(long id, SpecialityStatusParam param);
        void Update(List<SpecialityStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        SpecialityStatusResult Find(long id);
        List<SpecialityStatusResult> Find();
    }
}
