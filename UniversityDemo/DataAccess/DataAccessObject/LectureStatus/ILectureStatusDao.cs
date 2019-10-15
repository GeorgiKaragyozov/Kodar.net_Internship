using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.LectureStatus
{
    public interface ILectureStatusDao
    {
        Data.Entity.Model.Status.LectureStatus Save(Data.Entity.Model.Status.LectureStatus entity);
        List<Data.Entity.Model.Status.LectureStatus> Save(List<Data.Entity.Model.Status.LectureStatus> entity);

        Data.Entity.Model.Status.LectureStatus Update(Data.Entity.Model.Status.LectureStatus entity);
        List<Data.Entity.Model.Status.LectureStatus> Update(List<Data.Entity.Model.Status.LectureStatus> entity);

        void Delete(long id);
        void Delete(Data.Entity.Model.Status.LectureStatus entity);
        void Delete(List<long> idList);

        List<Data.Entity.Model.Status.LectureStatus> Find();
        Data.Entity.Model.Status.LectureStatus Find(long id);
    }
}
