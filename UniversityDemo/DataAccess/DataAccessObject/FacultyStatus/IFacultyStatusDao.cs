using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.FacultyStatus
{
    public interface IFacultyStatusDao
    {
        Model.FacultyStatus Save(Model.FacultyStatus entity);
        List<Model.FacultyStatus> Save(List<Model.FacultyStatus> entity);

        Model.FacultyStatus Update(Model.FacultyStatus entity);
        List<Model.FacultyStatus> Update(List<Model.FacultyStatus> entity);

        void Delete(long id);
        void Delete(Model.FacultyStatus entity);
        void Delete(List<long> idList);

        List<Model.FacultyStatus> Find();
        Model.FacultyStatus Find(long id);
    }
}
