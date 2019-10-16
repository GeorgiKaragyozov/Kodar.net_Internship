using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDiscipline;

namespace UniversityDemo.Business.Processor.TeacherDiscipline
{
    public interface ITeacherDisciplineProcessor
    {
        TeacherDisciplineResult Create(TeacherDisciplineParam param);
        List<TeacherDisciplineResult> Create(List<TeacherDisciplineParam> param);

        void Update(long id, TeacherDisciplineParam param);
        void Update(List<TeacherDisciplineParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        TeacherDisciplineResult Find(long id);
        List<TeacherDisciplineResult> Find();
    }
}
