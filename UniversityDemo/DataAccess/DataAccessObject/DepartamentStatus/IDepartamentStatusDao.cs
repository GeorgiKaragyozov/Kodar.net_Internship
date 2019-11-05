using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus
{
    public interface IDepartamentStatusDao
    {
        Model.DepartamentStatus Save(Model.DepartamentStatus entity);
        List<Model.DepartamentStatus> Save(List<Model.DepartamentStatus> entity);

        Model.DepartamentStatus Update(Model.DepartamentStatus entity);
        List<Model.DepartamentStatus> Update(List<Model.DepartamentStatus> entity);

        void Delete(long id);
        void Delete(Model.DepartamentStatus entity);
        void Delete(List<long> idList);

        List<Model.DepartamentStatus> Find();
        Model.DepartamentStatus Find(long id);
    }
}
