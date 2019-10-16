using System.Collections.Generic;
using UniversityDemo.Business.Convertor.FacultyStatus;

namespace UniversityDemo.Business.Processor.FacultyStatus
{
    public interface IFacultyStatusProcessor
    {
        FacultyStatusResult Create(FacultyStatusParam param);
        List<FacultyStatusResult> Create(List<FacultyStatusParam> param);

        void Update(long id, FacultyStatusParam param);
        void Update(List<FacultyStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        FacultyStatusResult Find(long id);
        List<FacultyStatusResult> Find();
    }
}
