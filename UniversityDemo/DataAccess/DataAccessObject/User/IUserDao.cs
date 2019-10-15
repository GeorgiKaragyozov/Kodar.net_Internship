using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.User
{
    public interface IUserDao
    {
        UniversityDemo.User Save(UniversityDemo.User entity);
        List<UniversityDemo.User> Save(List<UniversityDemo.User> entity);

        UniversityDemo.User Update(UniversityDemo.User entity);
        List<UniversityDemo.User> Update(List<UniversityDemo.User> entity);

        void Delete(long id);
        void Delete(UniversityDemo.User entity);
        void Delete(List<long> idList);

        List<UniversityDemo.User> Find();
        UniversityDemo.User Find(long id);
    }
}
