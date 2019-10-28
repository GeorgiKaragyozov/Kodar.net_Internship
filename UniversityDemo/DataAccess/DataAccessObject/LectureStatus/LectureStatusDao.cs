using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDemo.Data.Entity.Model.Status;

namespace UniversityDemo.DataAccess.DataAccessObject.LectureStatus
{
    public class LectureStatusDao : ILectureStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.Model.Status.LectureStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Model.Status.LectureStatus entity)
        {
            LectureStatusDaoStorage.LecturesStatus.Remove(entity);
            LectureStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Model.Status.LectureStatus> Find()
        {
            return LectureStatusDaoStorage.LecturesStatus;
        }

        public Data.Entity.Model.Status.LectureStatus Find(long id)
        {
            return LectureStatusDaoStorage.LecturesStatus
                .Where(x => x.Id == id)
                .Single();
        }

        public Data.Entity.Model.Status.LectureStatus Save(Data.Entity.Model.Status.LectureStatus entity)
        {
            LectureStatusDaoStorage.LecturesStatus.Add(entity);
            LectureStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Model.Status.LectureStatus> Save(List<Data.Entity.Model.Status.LectureStatus> entity)
        {
            entity.ForEach(x => LectureStatusDaoStorage.LecturesStatus.Add(x));

            entity.ForEach(ent => LectureStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Data.Entity.Model.Status.LectureStatus Update(Data.Entity.Model.Status.LectureStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Data.Entity.Model.Status.LectureStatus> Update(List<Data.Entity.Model.Status.LectureStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
