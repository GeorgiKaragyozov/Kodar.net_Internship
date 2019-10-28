using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.StudentStatus
{
    public class StudentStatusDao : IStudentStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.StudentStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.StudentStatus entity)
        {
            StudentStatusDaoStorage.Statuses.Remove(entity);
            StudentStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.StudentStatus> Find()
        {
            return StudentStatusDaoStorage.Statuses;
        }

        public UniversityDemo.StudentStatus Find(long id)
        {
            return StudentStatusDaoStorage.Statuses
             .Where(x => x.Id == id)
             .Single();
        }

        public UniversityDemo.StudentStatus Save(UniversityDemo.StudentStatus entity)
        {
            StudentStatusDaoStorage.Statuses.Add(entity);
            StudentStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.StudentStatus> Save(List<UniversityDemo.StudentStatus> entity)
        {
            entity.ForEach(x => StudentStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => StudentStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.StudentStatus Update(UniversityDemo.StudentStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.StudentStatus> Update(List<UniversityDemo.StudentStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
