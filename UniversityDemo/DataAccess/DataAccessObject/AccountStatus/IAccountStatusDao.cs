using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.AccountStatus
{
    public interface IAccountStatusDao
    {
        UniversityDemo.AccountStatus Save(UniversityDemo.AccountStatus entity);
        List<UniversityDemo.AccountStatus> Save(List<UniversityDemo.AccountStatus> entity);

        UniversityDemo.AccountStatus Update(UniversityDemo.AccountStatus entity);
        List<UniversityDemo.AccountStatus> Update(List<UniversityDemo.AccountStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.AccountStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.AccountStatus> Find();
        UniversityDemo.AccountStatus Find(long id);
    }
}
