using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Speciality
{
    public class SpecialityDao : ISpecialityDao
    {
        public void Delete(long id)
        {
            Model.Speciality entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.Speciality entity)
        {
            SpecialityDaoStorage.Specialities.Remove(entity);
            SpecialityDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Speciality> Find()
        {
            return SpecialityDaoStorage.Specialities;
        }

        public Model.Speciality Find(long id)
        {
            return SpecialityDaoStorage.Specialities
              .Where(x => x.Id == id)
              .Single();
        }

        public Model.Speciality Save(Model.Speciality entity)
        {
            SpecialityDaoStorage.Specialities.Add(entity);
            SpecialityDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Speciality> Save(List<Model.Speciality> entity)
        {
            entity.ForEach(x => SpecialityDaoStorage.Specialities.Add(x));

            entity.ForEach(ent => SpecialityDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Speciality Update(Model.Speciality entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Speciality> Update(List<Model.Speciality> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
