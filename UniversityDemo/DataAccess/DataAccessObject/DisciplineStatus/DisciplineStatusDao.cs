using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus
{
    public class DisciplineStatusDao : IDisciplineStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.DisciplineStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.DisciplineStatus entity)
        {
            DisciplineStatusDaoStorage.DisciplinesStatus.Remove(entity);
            DisciplineStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.DisciplineStatus> Find()
        {
            return DisciplineStatusDaoStorage.DisciplinesStatus;
        }

        public UniversityDemo.DisciplineStatus Find(long id)
        {
            return DisciplineStatusDaoStorage.DisciplinesStatus
                 .Where(x => x.Id == id)
                 .Single();
        }

        public UniversityDemo.DisciplineStatus Save(UniversityDemo.DisciplineStatus entity)
        {
            DisciplineStatusDaoStorage.DisciplinesStatus.Add(entity);
            DisciplineStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.DisciplineStatus> Save(List<UniversityDemo.DisciplineStatus> entity)
        {
            entity.ForEach(x => DisciplineStatusDaoStorage.DisciplinesStatus.Add(x));

            entity.ForEach(ent => DisciplineStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.DisciplineStatus Update(UniversityDemo.DisciplineStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.DisciplineStatus> Update(List<UniversityDemo.DisciplineStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity; 
        }
    }
}
