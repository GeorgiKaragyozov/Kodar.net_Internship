using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Teacher
{
    public class TeacherDao : ITeacherDao
    {
        public void Delete(long id)
        {
            Model.Teacher entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Teacher entity)
        {
            TeacherDaoStorage.Teachers.Remove(entity);
            TeacherDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Teacher> Find()
        {
            return TeacherDaoStorage.Teachers;
        }

        public Model.Teacher Find(long id)
        {
            return TeacherDaoStorage.Teachers
            .Where(x => x.Id == id)
            .Single();
        }

        public Model.Teacher Save(Model.Teacher entity)
        {
            TeacherDaoStorage.Teachers.Add(entity);
            TeacherDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Teacher> Save(List<Model.Teacher> entity)
        {
            entity.ForEach(x => TeacherDaoStorage.Teachers.Add(x));

            entity.ForEach(ent => TeacherDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Teacher Update(Model.Teacher entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Teacher> Update(List<Model.Teacher> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
