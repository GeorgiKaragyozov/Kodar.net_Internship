using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Departament
{
    public interface IDepartamentDao
    {
        UniversityDemo.Departament Save(UniversityDemo.Departament entity);
        List<UniversityDemo.Departament> Save(List<UniversityDemo.Departament> entity);

        UniversityDemo.Departament Update(UniversityDemo.Departament entity);
        List<UniversityDemo.Departament> Update(List<UniversityDemo.Departament> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Departament entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Departament> Find();
        UniversityDemo.Departament Find(long id);
    }
}
