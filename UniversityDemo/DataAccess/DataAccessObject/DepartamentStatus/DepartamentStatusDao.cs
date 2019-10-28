using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus
{
    public class DepartamentStatusDao : IDepartamentStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.DepartamentStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.DepartamentStatus entity)
        {
            DepartamentStatusDaoStorage.DepartamentsStatus.Remove(entity);
            DepartamentStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.DepartamentStatus> Find()
        {
            return DepartamentStatusDaoStorage.DepartamentsStatus;
        }

        public UniversityDemo.DepartamentStatus Find(long id)
        {
            return DepartamentStatusDaoStorage.DepartamentsStatus
                .Where(x => x.Id == id)
                .Single();
        }

        public UniversityDemo.DepartamentStatus Save(UniversityDemo.DepartamentStatus entity)
        {
            DepartamentStatusDaoStorage.DepartamentsStatus.Add(entity);
            DepartamentStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.DepartamentStatus> Save(List<UniversityDemo.DepartamentStatus> entity)
        {
            entity.ForEach(x => DepartamentStatusDaoStorage.DepartamentsStatus.Add(x));

            entity.ForEach(ent => DepartamentStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.DepartamentStatus Update(UniversityDemo.DepartamentStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.DepartamentStatus> Update(List<UniversityDemo.DepartamentStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
