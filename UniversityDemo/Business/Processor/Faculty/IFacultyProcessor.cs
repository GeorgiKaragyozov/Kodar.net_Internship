using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Faculty;

namespace UniversityDemo.Business.Processor.Faculty
{
    public interface IFacultyProcessor
    {
        FacultyResult Create(FacultyParam param);
        List<FacultyResult> Create(List<FacultyParam> param);

        void Update(long id, FacultyParam param);
        void Update(List<FacultyParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        FacultyResult Find(long id);
        List<FacultyResult> Find();
    }
}
