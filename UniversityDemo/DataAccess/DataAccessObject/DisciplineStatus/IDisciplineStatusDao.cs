using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus
{
    public interface IDisciplineStatusDao
    {
        Model.DisciplineStatus Save(Model.DisciplineStatus entity);
        List<Model.DisciplineStatus> Save(List<Model.DisciplineStatus> entity);

        Model.DisciplineStatus Update(Model.DisciplineStatus entity);
        List<Model.DisciplineStatus> Update(List<Model.DisciplineStatus> entity);

        void Delete(long id);
        void Delete(Model.DisciplineStatus entity);
        void Delete(List<long> idList);

        List<Model.DisciplineStatus> Find();
        Model.DisciplineStatus Find(long id);
    }
}
