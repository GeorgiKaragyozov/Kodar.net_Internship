using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Faculty
{
    public interface IFacultyDao
    {
        Model.Faculty Save(Model.Faculty entity);
        List<Model.Faculty> Save(List<Model.Faculty> entity);

        Model.Faculty Update(Model.Faculty entity);
        List<Model.Faculty> Update(List<Model.Faculty> entity);

        void Delete(long id);
        void Delete(Model.Faculty entity);
        void Delete(List<long> idList);

        List<Model.Faculty> Find();
        Model.Faculty Find(long id);
    }
}
