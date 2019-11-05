using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.StudentStatus
{
    public interface IStudentStatusDao
    {
        Model.StudentStatus Save(Model.StudentStatus entity);
        List<Model.StudentStatus> Save(List<Model.StudentStatus> entity);

        Model.StudentStatus Update(Model.StudentStatus entity);
        List<Model.StudentStatus> Update(List<Model.StudentStatus> entity);

        void Delete(long id);
        void Delete(Model.StudentStatus entity);
        void Delete(List<long> idList);

        List<Model.StudentStatus> Find();
        Model.StudentStatus Find(long id);
    }
}
