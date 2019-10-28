using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Account entity = Find(id);
            Delete(entity);
        }   

        public void Delete(UniversityDemo.Account entity)
        {
            AccountStorage.Accounts.Remove(entity);
            AccountStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<UniversityDemo.Account> Find()
        {
            return AccountStorage.Accounts;
        }

        /// <summary>
        /// Finds an account by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UniversityDemo.Account Find(long id)
        {
            return AccountStorage.Accounts
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        /// <summary>
        /// Finds an account by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public UniversityDemo.Account Find(string name)
        {
            return AccountStorage.Accounts
                .Where(n => n.Name == name)
                .Single();
        }

        public List<UniversityDemo.Account> FindByCode(string code)
        {
            return AccountStorage.Accounts
                .Where(n => n.Code.ToLower().Equals(code.ToLower()))
                .ToList();
        }

        public List<UniversityDemo.Account> FindByDescription(string description)
        {
            return AccountStorage.Accounts
                .Where(n => n.Description.ToLower().Equals(description.ToLower()))
                .ToList();
        }

        public UniversityDemo.Account Save(UniversityDemo.Account entity)
        {
            AccountStorage.Accounts.Add(entity);
            AccountStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<UniversityDemo.Account> Save(List<UniversityDemo.Account> entity)
        {
            entity.ForEach(ent => AccountStorage.Accounts.Add(ent));

            entity.ForEach(ent => AccountStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public UniversityDemo.Account Update(UniversityDemo.Account entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<UniversityDemo.Account> Update(List<UniversityDemo.Account> entity)
        {
            entity.ForEach(ent => Update(ent));
            
            return entity;
        }
    }
}
