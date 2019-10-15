using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.StudentStatus
{
    public interface IStudentStatusDao
    {
        UniversityDemo.StudentStatus Save(UniversityDemo.StudentStatus entity);
        List<UniversityDemo.StudentStatus> Save(List<UniversityDemo.StudentStatus> entity);

        UniversityDemo.StudentStatus Update(UniversityDemo.StudentStatus entity);
        List<UniversityDemo.StudentStatus> Update(List<UniversityDemo.StudentStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.StudentStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.StudentStatus> Find();
        UniversityDemo.StudentStatus Find(long id);
    }
}
