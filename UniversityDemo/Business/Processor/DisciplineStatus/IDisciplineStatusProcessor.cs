using System.Collections.Generic;
using UniversityDemo.Business.Convertor.DisciplineStatus;

namespace UniversityDemo.Business.Processor.DisciplineStatus
{
    public interface IDisciplineStatusProcessor
    {
        DisciplineStatusResult Create(DisciplineStatusParam param);
        List<DisciplineStatusResult> Create(List<DisciplineStatusParam> param);

        void Update(long id, DisciplineStatusParam param);
        void Update(List<DisciplineStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        DisciplineStatusResult Find(long id);
        List<DisciplineStatusResult> Find();
    }
}
