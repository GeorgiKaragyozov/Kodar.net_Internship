using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Discipline
{
    public interface IDisciplineDao
    {
        Model.Discipline Save(Model.Discipline entity);
        List<Model.Discipline> Save(List<Model.Discipline> entity);

        Model.Discipline Update(Model.Discipline entity);
        List<Model.Discipline> Update(List<Model.Discipline> entity);

        void Delete(long id);
        void Delete(Model.Discipline entity);
        void Delete(List<long> idList);

        List<Model.Discipline> Find();
        Model.Discipline Find(long id);
    }
}
