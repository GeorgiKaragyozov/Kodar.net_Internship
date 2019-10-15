using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Lecture
{
    public interface ILectureDao
    {
        Model.Lecture Save(Model.Lecture entity);
        List<Model.Lecture> Save(List<Model.Lecture> entity);

        Model.Lecture Update(Model.Lecture entity);
        List<Model.Lecture> Update(List<Model.Lecture> entity);

        void Delete(long id);
        void Delete(Model.Lecture entity);
        void Delete(List<long> idList);

        List<Model.Lecture> Find();
        Model.Lecture Find(long id);
    }
}
