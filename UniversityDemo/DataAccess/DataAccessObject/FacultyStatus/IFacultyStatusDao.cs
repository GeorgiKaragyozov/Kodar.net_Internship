using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.FacultyStatus
{
    public interface IFacultyStatusDao
    {
        UniversityDemo.FacultyStatus Save(UniversityDemo.FacultyStatus entity);
        List<UniversityDemo.FacultyStatus> Save(List<UniversityDemo.FacultyStatus> entity);

        UniversityDemo.FacultyStatus Update(UniversityDemo.FacultyStatus entity);
        List<UniversityDemo.FacultyStatus> Update(List<UniversityDemo.FacultyStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.FacultyStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.FacultyStatus> Find();
        UniversityDemo.FacultyStatus Find(long id);
    }
}
