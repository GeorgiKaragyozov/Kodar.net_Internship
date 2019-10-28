using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Faculty
{
    public class FacultyDao : IFacultyDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Faculty entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Faculty entity)
        {
            FacultyDaoStorage.Faculties.Remove(entity);
            FacultyDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Faculty> Find()
        {
            return FacultyDaoStorage.Faculties;
        }

        public UniversityDemo.Faculty Find(long id)
        {
            return FacultyDaoStorage.Faculties
                 .Where(x => x.Id == id)
                 .Single();
        }

        public UniversityDemo.Faculty Save(UniversityDemo.Faculty entity)
        {
            FacultyDaoStorage.Faculties.Add(entity);
            FacultyDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Faculty> Save(List<UniversityDemo.Faculty> entity)
        {
            entity.ForEach(x => FacultyDaoStorage.Faculties.Add(x));

            entity.ForEach(ent => FacultyDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Faculty Update(UniversityDemo.Faculty entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Faculty> Update(List<UniversityDemo.Faculty> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
