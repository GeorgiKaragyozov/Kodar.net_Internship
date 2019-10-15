using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus
{
    public interface IDepartamentStatusDao
    {
        UniversityDemo.DepartamentStatus Save(UniversityDemo.DepartamentStatus entity);
        List<UniversityDemo.DepartamentStatus> Save(List<UniversityDemo.DepartamentStatus> entity);

        UniversityDemo.DepartamentStatus Update(UniversityDemo.DepartamentStatus entity);
        List<UniversityDemo.DepartamentStatus> Update(List<UniversityDemo.DepartamentStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.DepartamentStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.DepartamentStatus> Find();
        UniversityDemo.DepartamentStatus Find(long id);
    }
}
