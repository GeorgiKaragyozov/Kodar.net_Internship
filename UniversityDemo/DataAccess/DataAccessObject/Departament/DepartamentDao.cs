using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Departament
{
    public class DepartamentDao : IDepartamentDao
    {
        public void Delete(long id)
        {
            Model.Departament entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Departament entity)
        {
            DepartamentDaoStorage.Departaments.Remove(entity);
            DepartamentDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Departament> Find()
        {
            return DepartamentDaoStorage.Departaments;
        }

        public Model.Departament Find(long id)
        {
            return DepartamentDaoStorage.Departaments
                .Where(x => x.Id == id)
                .Single();
        }

        public Model.Departament Save(Model.Departament entity)
        {
            DepartamentDaoStorage.Departaments.Add(entity);
            DepartamentDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Departament> Save(List<Model.Departament> entity)
        {
            entity.ForEach(x => DepartamentDaoStorage.Departaments.Add(x));

            entity.ForEach(ent => DepartamentDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Departament Update(Model.Departament entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Departament> Update(List<Model.Departament> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
