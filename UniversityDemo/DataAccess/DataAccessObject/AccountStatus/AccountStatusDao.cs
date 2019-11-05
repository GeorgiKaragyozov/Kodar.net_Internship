using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.AccountStatus
{
    public class AccountStatusDao : IAccountStatusDao
    {
        public void Delete(long id)
        {
            Model.AccountStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(Model.AccountStatus entity)
        {
            AccountStatusStorage.AccountStatuses.Remove(entity);
            AccountStatusStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.AccountStatus> Find()
        {
            return AccountStatusStorage.AccountStatuses;
        }

        public Model.AccountStatus Find(long id)
        {
            return AccountStatusStorage.AccountStatuses
                .Where(x => x.Id == id)
                .Single();
        }

        /// <summary>
        /// Finds an account by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Model.AccountStatus Find(string name)
        {
            return AccountStatusStorage.AccountStatuses
                .Where(n => n.Name == name)
                .Single();
        }

        public Model.AccountStatus Save(Model.AccountStatus entity)
        {
            AccountStatusStorage.AccountStatuses.Add(entity);
            AccountStatusStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.AccountStatus> Save(List<Model.AccountStatus> entity)
        {
            entity.ForEach(x => AccountStatusStorage.AccountStatuses.Add(x));

            entity.ForEach(ent => AccountStatusStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.AccountStatus Update(Model.AccountStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.AccountStatus> Update(List<Model.AccountStatus> entity)
        {
            entity.ForEach(x => Update(x));

            return entity;
        }
    }
}
