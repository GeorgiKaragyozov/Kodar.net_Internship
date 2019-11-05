using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherStatus
{
    public interface ITeacherStatusDao
    {
        Model.TeacherStatus Save(Model.TeacherStatus entity);
        List<Model.TeacherStatus> Save(List<Model.TeacherStatus> entity);

        Model.TeacherStatus Update(Model.TeacherStatus entity);
        List<Model.TeacherStatus> Update(List<Model.TeacherStatus> entity);

        void Delete(long id);
        void Delete(Model.TeacherStatus entity);
        void Delete(List<long> idList);

        List<Model.TeacherStatus> Find();
        Model.TeacherStatus Find(long id);
    }
}
