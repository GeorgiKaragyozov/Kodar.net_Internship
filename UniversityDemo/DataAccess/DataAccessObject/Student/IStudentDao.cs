using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Student
{
    public interface IStudentDao
    {
        Model.Student Save(Model.Student entity);
        List<Model.Student> Save(List<Model.Student> entity);

        Model.Student Update(Model.Student entity);
        List<Model.Student> Update(List<Model.Student> entity);

        void Delete(long id);
        void Delete(Model.Student entity);
        void Delete(List<long> idList);

        List<Model.Student> Find();
        Model.Student Find(long id);
    }
}
