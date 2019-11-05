using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.LectureStatus
{
    public class LectureStatusDao : ILectureStatusDao
    {
        public void Delete(long id)
        {
            Model.LectureStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.LectureStatus entity)
        {
            LectureStatusDaoStorage.LecturesStatus.Remove(entity);
            LectureStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.LectureStatus> Find()
        {
            return LectureStatusDaoStorage.LecturesStatus;
        }

        public Model.LectureStatus Find(long id)
        {
            return LectureStatusDaoStorage.LecturesStatus
                .Where(x => x.Id == id)
                .Single();
        }

        public Model.LectureStatus Save(Model.LectureStatus entity)
        {
            LectureStatusDaoStorage.LecturesStatus.Add(entity);
            LectureStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.LectureStatus> Save(List<Model.LectureStatus> entity)
        {
            entity.ForEach(x => LectureStatusDaoStorage.LecturesStatus.Add(x));

            entity.ForEach(ent => LectureStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.LectureStatus Update(Model.LectureStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.LectureStatus> Update(List<Model.LectureStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
