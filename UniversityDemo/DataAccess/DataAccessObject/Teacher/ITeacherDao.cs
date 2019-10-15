using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Teacher
{
    public interface ITeacherDao
    {
        UniversityDemo.Teacher Save(UniversityDemo.Teacher entity);
        List<UniversityDemo.Teacher> Save(List<UniversityDemo.Teacher> entity);

        UniversityDemo.Teacher Update(UniversityDemo.Teacher entity);
        List<UniversityDemo.Teacher> Update(List<UniversityDemo.Teacher> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Teacher entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Teacher> Find();
        UniversityDemo.Teacher Find(long id);
    }
}
