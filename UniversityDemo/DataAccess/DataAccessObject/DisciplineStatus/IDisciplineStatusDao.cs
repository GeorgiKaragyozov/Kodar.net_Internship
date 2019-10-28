using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus
{
    public interface IDisciplineStatusDao
    {
        UniversityDemo.DisciplineStatus Save(UniversityDemo.DisciplineStatus entity);
        List<UniversityDemo.DisciplineStatus> Save(List<UniversityDemo.DisciplineStatus> entity);

        UniversityDemo.DisciplineStatus Update(UniversityDemo.DisciplineStatus entity);
        List<UniversityDemo.DisciplineStatus> Update(List<UniversityDemo.DisciplineStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.DisciplineStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.DisciplineStatus> Find();
        UniversityDemo.DisciplineStatus Find(long id);
    }
}
