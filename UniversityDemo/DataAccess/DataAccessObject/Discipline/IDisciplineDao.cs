using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Discipline
{
    public interface IDisciplineDao
    {
        UniversityDemo.Discipline Save(UniversityDemo.Discipline entity);
        List<UniversityDemo.Discipline> Save(List<UniversityDemo.Discipline> entity);

        UniversityDemo.Discipline Update(UniversityDemo.Discipline entity);
        List<UniversityDemo.Discipline> Update(List<UniversityDemo.Discipline> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Discipline entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Discipline> Find();
        UniversityDemo.Discipline Find(long id);
    }
}
