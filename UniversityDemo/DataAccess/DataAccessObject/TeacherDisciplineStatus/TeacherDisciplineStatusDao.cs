using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDemo.Data.Entity.Model.Status;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusDao : ITeacherDisciplineStatusDao
    {
        public void Delete(long id)
        {
            Data.Entity.Model.Status.TeacherDisciplineStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Model.Status.TeacherDisciplineStatus entity)
        {
            TeacherDisciplineStatusDaoStorage.Statuses.Remove(entity);
            TeacherDisciplineStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Model.Status.TeacherDisciplineStatus> Find()
        {
            return TeacherDisciplineStatusDaoStorage.Statuses;
        }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Find(long id)
        {
            return TeacherDisciplineStatusDaoStorage.Statuses
            .Where(x => x.Id == id)
            .Single();
        }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Save(Data.Entity.Model.Status.TeacherDisciplineStatus entity)
        {
            TeacherDisciplineStatusDaoStorage.Statuses.Add(entity);
            TeacherDisciplineStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Model.Status.TeacherDisciplineStatus> Save(List<Data.Entity.Model.Status.TeacherDisciplineStatus> entity)
        {
            entity.ForEach(x => TeacherDisciplineStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => TeacherDisciplineStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Data.Entity.Model.Status.TeacherDisciplineStatus Update(Data.Entity.Model.Status.TeacherDisciplineStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Data.Entity.Model.Status.TeacherDisciplineStatus> Update(List<Data.Entity.Model.Status.TeacherDisciplineStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
