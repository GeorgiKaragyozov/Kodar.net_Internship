using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public interface IAccountDao
    {   
        UniversityDemo.Account Save(UniversityDemo.Account entity);
        List<UniversityDemo.Account> Save(List<UniversityDemo.Account> entity);

        UniversityDemo.Account Update(UniversityDemo.Account entity);
        List<UniversityDemo.Account> Update(List<UniversityDemo.Account> entity);

        void Delete(long id);
        void Delete(UniversityDemo.Account entity);
        void Delete(List<long> idList);

        List<UniversityDemo.Account> Find();
        UniversityDemo.Account Find(long id);
    }
}
