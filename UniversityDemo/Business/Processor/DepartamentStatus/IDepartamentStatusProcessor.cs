using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DepartamentStatus;

namespace UniversityDemo.Business.Processor.DepartamentStatus
{
    public interface IDepartamentStatusProcessor
    {
        DepartamentStatusResult Create(DepartamentStatusParam param);
        List<DepartamentStatusResult> Create(List<DepartamentStatusParam> param);

        void Update(long id, DepartamentStatusParam param);
        void Update(List<DepartamentStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        DepartamentStatusResult Find(long id);
        List<DepartamentStatusResult> Find();
    }
}
