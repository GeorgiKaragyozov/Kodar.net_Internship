using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Student
{
    public class StudentDao : IStudentDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Student entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Student entity)
        {
            StudentDaoStorage.Students.Remove(entity);
            StudentDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Student> Find()
        {
            return StudentDaoStorage.Students;
        }

        public UniversityDemo.Student Find(long id)
        {
            return StudentDaoStorage.Students
                .Where(x => x.Id == id)
                .Single();
        }

        public UniversityDemo.Student Save(UniversityDemo.Student entity)
        {
            StudentDaoStorage.Students.Add(entity);
            StudentDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Student> Save(List<UniversityDemo.Student> entity)
        {
            entity.ForEach(x => StudentDaoStorage.Students.Add(x));

            entity.ForEach(ent => StudentDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Student Update(UniversityDemo.Student entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Student> Update(List<UniversityDemo.Student> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
