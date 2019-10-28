using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus
{
    public class SpecialityStatusDao : ISpecialityStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.SpecialityStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.SpecialityStatus entity)
        {
            SpecialityStatusDaoStorage.Statuses.Remove(entity);
            SpecialityStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.SpecialityStatus> Find()
        {
            return SpecialityStatusDaoStorage.Statuses;
        }

        public UniversityDemo.SpecialityStatus Find(long id)
        {
            return SpecialityStatusDaoStorage.Statuses
               .Where(x => x.Id == id)
               .Single();
        }

        public UniversityDemo.SpecialityStatus Save(UniversityDemo.SpecialityStatus entity)
        {
            SpecialityStatusDaoStorage.Statuses.Add(entity);
            SpecialityStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.SpecialityStatus> Save(List<UniversityDemo.SpecialityStatus> entity)
        {
            entity.ForEach(x => SpecialityStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => SpecialityStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.SpecialityStatus Update(UniversityDemo.SpecialityStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.SpecialityStatus> Update(List<UniversityDemo.SpecialityStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
