using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Faculty
{
    public class FacultyDao : IFacultyDao
    {
        public void Delete(long id)
        {
            Model.Faculty entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Faculty entity)
        {
            FacultyDaoStorage.Faculties.Remove(entity);
            FacultyDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Faculty> Find()
        {
            return FacultyDaoStorage.Faculties;
        }

        public Model.Faculty Find(long id)
        {
            return FacultyDaoStorage.Faculties
                 .Where(x => x.Id == id)
                 .Single();
        }

        public Model.Faculty Save(Model.Faculty entity)
        {
            FacultyDaoStorage.Faculties.Add(entity);
            FacultyDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Faculty> Save(List<Model.Faculty> entity)
        {
            entity.ForEach(x => FacultyDaoStorage.Faculties.Add(x));

            entity.ForEach(ent => FacultyDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Faculty Update(Model.Faculty entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Faculty> Update(List<Model.Faculty> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
