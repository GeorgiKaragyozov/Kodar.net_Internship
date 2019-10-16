using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Teacher;

namespace UniversityDemo.Business.Processor.Teacher
{
    public interface ITeacherProcessor
    {
        TeacherResult Create(TeacherParam param);
        List<TeacherResult> Create(List<TeacherParam> param);

        void Update(long id, TeacherParam param);
        void Update(List<TeacherParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        TeacherResult Find(long id);
        List<TeacherResult> Find();
    }
}
