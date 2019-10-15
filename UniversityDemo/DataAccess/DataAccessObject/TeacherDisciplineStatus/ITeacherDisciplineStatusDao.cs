using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public interface ITeacherDisciplineStatusDao
    {
        Data.Entity.Model.Status.TeacherDisciplineStatus Save(Data.Entity.Model.Status.TeacherDisciplineStatus entity);
        List<Data.Entity.Model.Status.TeacherDisciplineStatus> Save(List<Data.Entity.Model.Status.TeacherDisciplineStatus> entity);

        Data.Entity.Model.Status.TeacherDisciplineStatus Update(Data.Entity.Model.Status.TeacherDisciplineStatus entity);
        List<Data.Entity.Model.Status.TeacherDisciplineStatus> Update(List<Data.Entity.Model.Status.TeacherDisciplineStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.Model.Status.TeacherDisciplineStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.Model.Status.TeacherDisciplineStatus> Find();
        Data.Entity.Model.Status.TeacherDisciplineStatus Find(long id);
    }
}
