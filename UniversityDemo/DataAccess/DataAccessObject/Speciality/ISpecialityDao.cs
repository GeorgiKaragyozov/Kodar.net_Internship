using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Speciality
{
    public interface ISpecialityDao
    {
        UniversityDemo.Speciality Save(UniversityDemo.Speciality entity);
        List<UniversityDemo.Speciality> Save(List<UniversityDemo.Speciality> entity);

        UniversityDemo.Speciality Update(UniversityDemo.Speciality entity);
        List<UniversityDemo.Speciality> Update(List<UniversityDemo.Speciality> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Speciality entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Speciality> Find();
        UniversityDemo.Speciality Find(long id);
    }
}
