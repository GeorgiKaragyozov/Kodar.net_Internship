using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            UniversityDemo.Account enity = Find(id);
            Delete(id);
        }   

        public void Delete(UniversityDemo.Account entity)
        {
            AccountStorage.Accounts.Remove(entity);
            //Delete(Find(entity.Id));
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
            /*error */
            return AccountStorage.Accounts.Where(x => x.Id == id).Single();
        }

        /// <summary>
        /// Finds an account by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<UniversityDemo.Account> Find(string name)
        {
            //return AccountStorage.Accounts.Where(n => n.FirstName == name).ToList();

            return AccountStorage.Accounts.Where(n => n.FirstName.ToLower().Equals(name)).ToList();
        }

        public UniversityDemo.Account Save(UniversityDemo.Account entity)
        {
            AccountStorage.Accounts.Add(entity);

            return entity;
        }

        public List<UniversityDemo.Account> Save(List<UniversityDemo.Account> entity)
        {
            entity.ForEach(x => AccountStorage.Accounts.Add(x));

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
            entity.ForEach(x => Update(x));
            
            return entity;
        }
    }
}
