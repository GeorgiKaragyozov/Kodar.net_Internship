using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.LectureStatus
{
    public interface ILectureStatusDao
    {
        Model.LectureStatus Save(Model.LectureStatus entity);
        List<Model.LectureStatus> Save(List<Model.LectureStatus> entity);

        Model.LectureStatus Update(Model.LectureStatus entity);
        List<Model.LectureStatus> Update(List<Model.LectureStatus> entity);

        void Delete(long id);
        void Delete(Model.LectureStatus entity);
        void Delete(List<long> idList);

        List<Model.LectureStatus> Find();
        Model.LectureStatus Find(long id);
    }
}
