using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Discipline;

namespace UniversityDemo.Business.Processor.Discipline
{
    public interface IDisciplineProcessor
    {
        DisciplineResult Create(DisciplineParam param);
        List<DisciplineResult> Create(List<DisciplineParam> param);

        void Update(long id, DisciplineParam param);
        void Update(List<DisciplineParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        DisciplineResult Find(long id);
        List<DisciplineResult> Find();
    }
}
