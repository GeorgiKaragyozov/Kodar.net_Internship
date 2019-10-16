using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherStatus;

namespace UniversityDemo.Business.Processor.TeacherStatus
{
    public interface ITeacherStatusProcessor
    {
        TeacherStatusResult Create(TeacherStatusParam param);
        List<TeacherStatusResult> Create(List<TeacherStatusParam> param);

        void Update(long id, TeacherStatusParam param);
        void Update(List<TeacherStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        TeacherStatusResult Find(long id);
        List<TeacherStatusResult> Find();
    }
}
