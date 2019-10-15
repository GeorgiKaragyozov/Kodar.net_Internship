using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Student
{
    public interface IStudentDao
    {
        UniversityDemo.Student Save(UniversityDemo.Student entity);
        List<UniversityDemo.Student> Save(List<UniversityDemo.Student> entity);

        UniversityDemo.Student Update(UniversityDemo.Student entity);
        List<UniversityDemo.Student> Update(List<UniversityDemo.Student> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Student entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Student> Find();
        UniversityDemo.Student Find(long id);
    }
}
