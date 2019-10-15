using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline
{
    public interface ITeacherDisciplineDao
    {
        Model.TeacherDiscipline Save(Model.TeacherDiscipline entity);
        List<Model.TeacherDiscipline> Save(List<Model.TeacherDiscipline> entity);

        Model.TeacherDiscipline Update(Model.TeacherDiscipline entity);
        List<Model.TeacherDiscipline> Update(List<Model.TeacherDiscipline> entity);

        void Delete(long id);
        void Delete(Model.TeacherDiscipline entity);
        void Delete(List<long> idList);

        List<Model.TeacherDiscipline> Find();
        Model.TeacherDiscipline Find(long id);
    }
}
