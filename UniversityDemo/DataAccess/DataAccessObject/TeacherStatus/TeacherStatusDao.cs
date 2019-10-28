using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDemo.Model.Accounts;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherStatus
{
    public class TeacherStatusDao : ITeacherStatusDao
    {
        public void Delete(long id)
        {
            Model.Accounts.TeacherStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Accounts.TeacherStatus entity)
        {
            TeacherStatusDaoStorage.Statuses.Remove(entity);
            TeacherStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Accounts.TeacherStatus> Find()
        {
            return TeacherStatusDaoStorage.Statuses;
        }

        public Model.Accounts.TeacherStatus Find(long id)
        {
            return TeacherStatusDaoStorage.Statuses
             .Where(x => x.Id == id)
             .Single();
        }

        public Model.Accounts.TeacherStatus Save(Model.Accounts.TeacherStatus entity)
        {
            TeacherStatusDaoStorage.Statuses.Add(entity);
            TeacherStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Accounts.TeacherStatus> Save(List<Model.Accounts.TeacherStatus> entity)
        {
            entity.ForEach(x => TeacherStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => TeacherStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Accounts.TeacherStatus Update(Model.Accounts.TeacherStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Accounts.TeacherStatus> Update(List<Model.Accounts.TeacherStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
