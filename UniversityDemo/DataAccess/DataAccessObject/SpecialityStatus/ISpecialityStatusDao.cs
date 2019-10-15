using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus
{
    public interface ISpecialityStatusDao
    {
        UniversityDemo.SpecialityStatus Save(UniversityDemo.SpecialityStatus entity);
        List<UniversityDemo.SpecialityStatus> Save(List<UniversityDemo.SpecialityStatus> entity);

        UniversityDemo.SpecialityStatus Update(UniversityDemo.SpecialityStatus entity);
        List<UniversityDemo.SpecialityStatus> Update(List<UniversityDemo.SpecialityStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.SpecialityStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.SpecialityStatus> Find();
        UniversityDemo.SpecialityStatus Find(long id);
    }
}
