using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Teacher
{
    public interface ITeacherDao
    {
        Model.Teacher Save(Model.Teacher entity);
        List<Model.Teacher> Save(List<Model.Teacher> entity);

        Model.Teacher Update(Model.Teacher entity);
        List<Model.Teacher> Update(List<Model.Teacher> entity);

        void Delete(long id);
        void Delete(Model.Teacher entity);
        void Delete(List<long> idList);

        List<Model.Teacher> Find();
        Model.Teacher Find(long id);
    }
}
