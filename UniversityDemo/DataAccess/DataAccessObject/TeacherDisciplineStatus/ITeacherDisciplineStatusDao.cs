using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusDao
    {
        Model.TeacherDisciplineStatus Save(Model.TeacherDisciplineStatus entity);
        List<Model.TeacherDisciplineStatus> Save(List<Model.TeacherDisciplineStatus> entity);

        Model.TeacherDisciplineStatus Update(Model.TeacherDisciplineStatus entity);
        List<Model.TeacherDisciplineStatus> Update(List<Model.TeacherDisciplineStatus> entity);

        void Delete(long id);
        void Delete(Model.TeacherDisciplineStatus entity);
        void Delete(List<long> idList);

        List<Model.TeacherDisciplineStatus> Find();
        Model.TeacherDisciplineStatus Find(long id);
    }
}
