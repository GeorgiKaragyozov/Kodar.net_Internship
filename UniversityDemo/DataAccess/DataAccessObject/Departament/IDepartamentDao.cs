using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Departament
{
    public interface IDepartamentDao
    {
        Model.Departament Save(Model.Departament entity);
        List<Model.Departament> Save(List<Model.Departament> entity);

        Model.Departament Update(Model.Departament entity);
        List<Model.Departament> Update(List<Model.Departament> entity);

        void Delete(long id);
        void Delete(Model.Departament entity);
        void Delete(List<long> idList);

        List<Model.Departament> Find();
        Model.Departament Find(long id);
    }
}
