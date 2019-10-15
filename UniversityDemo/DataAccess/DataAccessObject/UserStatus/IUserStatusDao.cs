using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.UserStatus
{
    public interface IUserStatusDao
    {
        UniversityDemo.UserStatus Save(UniversityDemo.UserStatus entity);
        List<UniversityDemo.UserStatus> Save(List<UniversityDemo.UserStatus> entity);

        UniversityDemo.UserStatus Update(UniversityDemo.UserStatus entity);
        List<UniversityDemo.UserStatus> Update(List<UniversityDemo.UserStatus> entity);

        void Delete(long id);
        void Delete(UniversityDemo.UserStatus entity);
        void Delete(List<long> idList);

        List<UniversityDemo.UserStatus> Find();
        UniversityDemo.UserStatus Find(long id);
    }
}
