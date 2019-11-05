using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus
{
    public class DepartamentStatusDao : IDepartamentStatusDao
    {
        public void Delete(long id)
        {
            Model.DepartamentStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.DepartamentStatus entity)
        {
            DepartamentStatusDaoStorage.DepartamentsStatus.Remove(entity);
            DepartamentStatusDaoStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.DepartamentStatus> Find()
        {
            return DepartamentStatusDaoStorage.DepartamentsStatus;
        }

        public Model.DepartamentStatus Find(long id)
        {
            return DepartamentStatusDaoStorage.DepartamentsStatus
                .Where(x => x.Id == id)
                .Single();
        }

        public Model.DepartamentStatus Save(Model.DepartamentStatus entity)
        {
            DepartamentStatusDaoStorage.DepartamentsStatus.Add(entity);
            DepartamentStatusDaoStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.DepartamentStatus> Save(List<Model.DepartamentStatus> entity)
        {
            entity.ForEach(x => DepartamentStatusDaoStorage.DepartamentsStatus.Add(x));

            entity.ForEach(ent => DepartamentStatusDaoStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.DepartamentStatus Update(Model.DepartamentStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.DepartamentStatus> Update(List<Model.DepartamentStatus> entity)
        {
            entity.ForEach(ent => Update(ent));

            return entity;
        }
    }
}
