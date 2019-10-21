using System;
using System.Collections.Generic;

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
            Delete(Find(entity.Id));
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public List<UniversityDemo.Account> Find()
        {
            throw new NotImplementedException();
        }

        public UniversityDemo.Account Find(long id)
        {
            UniversityDemo.Account entity = new UniversityDemo.Account() { Id = id };

            return entity;
        }

        public UniversityDemo.Account Save(UniversityDemo.Account entity)
        {
            return entity;
        }

        public List<UniversityDemo.Account> Save(List<UniversityDemo.Account> entity)
        {
            return entity;
        }

        public UniversityDemo.Account Update(UniversityDemo.Account entity)
        {
            throw new NotImplementedException();
        }

        public List<UniversityDemo.Account> Update(List<UniversityDemo.Account> entity)
        {
            throw new NotImplementedException();
        }
    }
}
