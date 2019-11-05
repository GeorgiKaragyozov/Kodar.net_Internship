using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.StudentStatus
{
    public class StudentStatusDao : IStudentStatusDao
    {
        public void Delete(long id)
        {
            Model.StudentStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.StudentStatus entity)
        {
            StudentStatusDaoStorage.Statuses.Remove(entity);
            StudentStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.StudentStatus> Find()
        {
            return StudentStatusDaoStorage.Statuses;
        }

        public Model.StudentStatus Find(long id)
        {
            return StudentStatusDaoStorage.Statuses
             .Where(x => x.Id == id)
             .Single();
        }

        public Model.StudentStatus Save(Model.StudentStatus entity)
        {
            StudentStatusDaoStorage.Statuses.Add(entity);
            StudentStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.StudentStatus> Save(List<Model.StudentStatus> entity)
        {
            entity.ForEach(x => StudentStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => StudentStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.StudentStatus Update(Model.StudentStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.StudentStatus> Update(List<Model.StudentStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
