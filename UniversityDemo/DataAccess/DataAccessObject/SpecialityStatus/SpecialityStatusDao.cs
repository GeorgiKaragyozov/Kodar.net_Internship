using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.SpecialityStatus
{
    public class SpecialityStatusDao : ISpecialityStatusDao
    {
        public void Delete(long id)
        {
            Model.SpecialityStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.SpecialityStatus entity)
        {
            SpecialityStatusDaoStorage.Statuses.Remove(entity);
            SpecialityStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.SpecialityStatus> Find()
        {
            return SpecialityStatusDaoStorage.Statuses;
        }

        public Model.SpecialityStatus Find(long id)
        {
            return SpecialityStatusDaoStorage.Statuses
               .Where(x => x.Id == id)
               .Single();
        }

        public Model.SpecialityStatus Save(Model.SpecialityStatus entity)
        {
            SpecialityStatusDaoStorage.Statuses.Add(entity);
            SpecialityStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.SpecialityStatus> Save(List<Model.SpecialityStatus> entity)
        {
            entity.ForEach(x => SpecialityStatusDaoStorage.Statuses.Add(x));

            entity.ForEach(ent => SpecialityStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.SpecialityStatus Update(Model.SpecialityStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.SpecialityStatus> Update(List<Model.SpecialityStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
