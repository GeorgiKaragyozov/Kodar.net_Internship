using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherStatus
{
    public class TeacherStatusDao : ITeacherStatusDao
    {
        public void Delete(long id)
        {
            Model.TeacherStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.TeacherStatus entity)
        {
            TeacherStatusDaoStorage.Statuses.Remove(entity);
            TeacherStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.TeacherStatus> Find()
        {
            return TeacherStatusDaoStorage.Statuses;
        }

        public Model.TeacherStatus Find(long id)
        {
            return TeacherStatusDaoStorage.Statuses
             .Where(x => x.Id == id)
             .Single();
        }

        public Model.TeacherStatus Save(Model.TeacherStatus entity)
        {
            TeacherStatusDaoStorage.Statuses.Add(entity);
            TeacherStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.TeacherStatus> Save(List<Model.TeacherStatus> entity)
        {
            entity.ForEach(x => TeacherStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => TeacherStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.TeacherStatus Update(Model.TeacherStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.TeacherStatus> Update(List<Model.TeacherStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
