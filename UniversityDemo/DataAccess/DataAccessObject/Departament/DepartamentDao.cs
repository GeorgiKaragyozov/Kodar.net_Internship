using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Departament
{
    public class DepartamentDao : IDepartamentDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Departament entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Departament entity)
        {
            DepartamentDaoStorage.Departaments.Remove(entity);
            DepartamentDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Departament> Find()
        {
            return DepartamentDaoStorage.Departaments;
        }

        public UniversityDemo.Departament Find(long id)
        {
            return DepartamentDaoStorage.Departaments
                .Where(x => x.Id == id)
                .Single();
        }

        public UniversityDemo.Departament Save(UniversityDemo.Departament entity)
        {
            DepartamentDaoStorage.Departaments.Add(entity);
            DepartamentDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Departament> Save(List<UniversityDemo.Departament> entity)
        {
            entity.ForEach(x => DepartamentDaoStorage.Departaments.Add(x));

            entity.ForEach(ent => DepartamentDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Departament Update(UniversityDemo.Departament entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Departament> Update(List<UniversityDemo.Departament> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
