using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Student
{
    public class StudentDao : IStudentDao
    {
        public void Delete(long id)
        {
            Model.Student entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Student entity)
        {
            StudentDaoStorage.Students.Remove(entity);
            StudentDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Student> Find()
        {
            return StudentDaoStorage.Students;
        }

        public Model.Student Find(long id)
        {
            return StudentDaoStorage.Students
                .Where(x => x.Id == id)
                .Single();
        }

        public Model.Student Save(Model.Student entity)
        {
            StudentDaoStorage.Students.Add(entity);
            StudentDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Student> Save(List<Model.Student> entity)
        {
            entity.ForEach(x => StudentDaoStorage.Students.Add(x));

            entity.ForEach(ent => StudentDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Student Update(Model.Student entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Student> Update(List<Model.Student> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
