using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDemo.Model;

namespace UniversityDemo.DataAccess.DataAccessObject.TeacherDiscipline
{
    public class TeacherDisciplineDao : ITeacherDisciplineDao
    {
        public void Delete(long id)
        {
            Model.TeacherDiscipline entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.TeacherDiscipline entity)
        {
            TeacherDisciplineDaoStorage.teacherDisciplines.Remove(entity);
            TeacherDisciplineDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.TeacherDiscipline> Find()
        {
            return TeacherDisciplineDaoStorage.teacherDisciplines;
        }

        public Model.TeacherDiscipline Find(long id)
        {
            return TeacherDisciplineDaoStorage.teacherDisciplines
            .Where(x => x.Id == id)
            .Single();
        }

        public Model.TeacherDiscipline Save(Model.TeacherDiscipline entity)
        {
            TeacherDisciplineDaoStorage.teacherDisciplines.Add(entity);
            TeacherDisciplineDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.TeacherDiscipline> Save(List<Model.TeacherDiscipline> entity)
        {
            entity.ForEach(x => TeacherDisciplineDaoStorage.teacherDisciplines.Add(x));

            entity.ForEach(ent => TeacherDisciplineDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.TeacherDiscipline Update(Model.TeacherDiscipline entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.TeacherDiscipline> Update(List<Model.TeacherDiscipline> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
