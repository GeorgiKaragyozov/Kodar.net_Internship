using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Speciality
{
    public class SpecialityDao : ISpecialityDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Speciality entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.Speciality entity)
        {
            SpecialityDaoStorage.Specialities.Remove(entity);
            SpecialityDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Speciality> Find()
        {
            return SpecialityDaoStorage.Specialities;
        }

        public UniversityDemo.Speciality Find(long id)
        {
            return SpecialityDaoStorage.Specialities
              .Where(x => x.Id == id)
              .Single();
        }

        public UniversityDemo.Speciality Save(UniversityDemo.Speciality entity)
        {
            SpecialityDaoStorage.Specialities.Add(entity);
            SpecialityDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Speciality> Save(List<UniversityDemo.Speciality> entity)
        {
            entity.ForEach(x => SpecialityDaoStorage.Specialities.Add(x));

            entity.ForEach(ent => SpecialityDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Speciality Update(UniversityDemo.Speciality entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Speciality> Update(List<UniversityDemo.Speciality> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
