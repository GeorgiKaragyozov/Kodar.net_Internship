using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.TeacherDisciplineStatus;

namespace UniversityDemo.Business.Processor.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusProcessor
    {
        TeacherDisciplineStatusResult Create(TeacherDisciplineStatusParam param);
        List<TeacherDisciplineStatusResult> Create(List<TeacherDisciplineStatusParam> param);

        void Update(long id, TeacherDisciplineStatusParam param);
        void Update(List<TeacherDisciplineStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        TeacherDisciplineStatusResult Find(long id);
        List<TeacherDisciplineStatusResult> Find();
    }
}
