using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.AccountStatus
{
    public class AccountStatusDao : IAccountStatusDao
    {
        public void Delete(long id)
        {
            UniversityDemo.AccountStatus entity = Find(id);
            Delete(entity);
        }

        public void Delete(UniversityDemo.AccountStatus entity)
        {
            AccountStatusStorage.AccountStatuses.Remove(entity);
            AccountStatusStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.AccountStatus> Find()
        {
            return AccountStatusStorage.AccountStatuses;
        }

        public UniversityDemo.AccountStatus Find(long id)
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
        public UniversityDemo.AccountStatus Find(string name)
        {
            return AccountStatusStorage.AccountStatuses
                .Where(n => n.Name == name)
                .Single();
        }

        public UniversityDemo.AccountStatus Save(UniversityDemo.AccountStatus entity)
        {
            AccountStatusStorage.AccountStatuses.Add(entity);
            AccountStatusStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.AccountStatus> Save(List<UniversityDemo.AccountStatus> entity)
        {
            entity.ForEach(x => AccountStatusStorage.AccountStatuses.Add(x));

            entity.ForEach(ent => AccountStatusStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.AccountStatus Update(UniversityDemo.AccountStatus entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.AccountStatus> Update(List<UniversityDemo.AccountStatus> entity)
        {
            entity.ForEach(x => Update(x));

            return entity;
        }
    }
}
