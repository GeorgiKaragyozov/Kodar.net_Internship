using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusDao : ITeacherDisciplineStatusDao
    {
        public void Delete(long id)
        {
            Model.TeacherDisciplineStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.TeacherDisciplineStatus entity)
        {
            TeacherDisciplineStatusDaoStorage.Statuses.Remove(entity);
            TeacherDisciplineStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.TeacherDisciplineStatus> Find()
        {
            return TeacherDisciplineStatusDaoStorage.Statuses;
        }

        public Model.TeacherDisciplineStatus Find(long id)
        {
            return TeacherDisciplineStatusDaoStorage.Statuses
            .Where(x => x.Id == id)
            .Single();
        }

        public Model.TeacherDisciplineStatus Save(Model.TeacherDisciplineStatus entity)
        {
            TeacherDisciplineStatusDaoStorage.Statuses.Add(entity);
            TeacherDisciplineStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.TeacherDisciplineStatus> Save(List<Model.TeacherDisciplineStatus> entity)
        {
            entity.ForEach(x => TeacherDisciplineStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => TeacherDisciplineStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.TeacherDisciplineStatus Update(Model.TeacherDisciplineStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.TeacherDisciplineStatus> Update(List<Model.TeacherDisciplineStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
