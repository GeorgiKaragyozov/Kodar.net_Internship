using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Teacher
{
    public class TeacherDao : ITeacherDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Teacher entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Teacher entity)
        {
            TeacherDaoStorage.Teachers.Remove(entity);
            TeacherDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Teacher> Find()
        {
            return TeacherDaoStorage.Teachers;
        }

        public UniversityDemo.Teacher Find(long id)
        {
            return TeacherDaoStorage.Teachers
            .Where(x => x.Id == id)
            .Single();
        }

        public UniversityDemo.Teacher Save(UniversityDemo.Teacher entity)
        {
            TeacherDaoStorage.Teachers.Add(entity);
            TeacherDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Teacher> Save(List<UniversityDemo.Teacher> entity)
        {
            entity.ForEach(x => TeacherDaoStorage.Teachers.Add(x));

            entity.ForEach(ent => TeacherDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Teacher Update(UniversityDemo.Teacher entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Teacher> Update(List<UniversityDemo.Teacher> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
