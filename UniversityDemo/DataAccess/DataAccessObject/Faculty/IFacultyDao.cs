using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Faculty
{
    public interface IFacultyDao
    {
        UniversityDemo.Faculty Save(UniversityDemo.Faculty entity);
        List<UniversityDemo.Faculty> Save(List<UniversityDemo.Faculty> entity);

        UniversityDemo.Faculty Update(UniversityDemo.Faculty entity);
        List<UniversityDemo.Faculty> Update(List<UniversityDemo.Faculty> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Faculty entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Faculty> Find();
        UniversityDemo.Faculty Find(long id);
    }
}
