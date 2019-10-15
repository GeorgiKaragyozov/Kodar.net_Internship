using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherStatus
{
    public interface ITeacherStatusDao
    {
        Model.Accounts.TeacherStatus Save(Model.Accounts.TeacherStatus entity);
        List<Model.Accounts.TeacherStatus> Save(List<Model.Accounts.TeacherStatus> entity);

        Model.Accounts.TeacherStatus Update(Model.Accounts.TeacherStatus entity);
        List<Model.Accounts.TeacherStatus> Update(List<Model.Accounts.TeacherStatus> entity);

        void Delete(long id);
        void Delete(Model.Accounts.TeacherStatus entity);
        void Delete(List<long> idList);

        List<Model.Accounts.TeacherStatus> Find();
        Model.Accounts.TeacherStatus Find(long id);
    }
}
