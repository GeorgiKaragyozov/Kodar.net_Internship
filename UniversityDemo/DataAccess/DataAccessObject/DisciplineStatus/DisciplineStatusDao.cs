using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus
{
    public class DisciplineStatusDao : IDisciplineStatusDao
    {
        public void Delete(long id)
        {
            Model.DisciplineStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.DisciplineStatus entity)
        {
            DisciplineStatusDaoStorage.DisciplinesStatus.Remove(entity);
            DisciplineStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.DisciplineStatus> Find()
        {
            return DisciplineStatusDaoStorage.DisciplinesStatus;
        }

        public Model.DisciplineStatus Find(long id)
        {
            return DisciplineStatusDaoStorage.DisciplinesStatus
                 .Where(x => x.Id == id)
                 .Single();
        }

        public Model.DisciplineStatus Save(Model.DisciplineStatus entity)
        {
            DisciplineStatusDaoStorage.DisciplinesStatus.Add(entity);
            DisciplineStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.DisciplineStatus> Save(List<Model.DisciplineStatus> entity)
        {
            entity.ForEach(x => DisciplineStatusDaoStorage.DisciplinesStatus.Add(x));

            entity.ForEach(ent => DisciplineStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.DisciplineStatus Update(Model.DisciplineStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.DisciplineStatus> Update(List<Model.DisciplineStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity; 
        }
    }
}
