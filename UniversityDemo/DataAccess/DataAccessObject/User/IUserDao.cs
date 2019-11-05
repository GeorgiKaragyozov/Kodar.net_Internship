using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.User
{
    public interface IUserDao
    {
        Model.User Save(Model.User entity);
        List<Model.User> Save(List<Model.User> entity);

        Model.User Update(Model.User entity);
        List<Model.User> Update(List<Model.User> entity);

        void Delete(long id);
        void Delete(Model.User entity);
        void Delete(List<long> idList);

        List<Model.User> Find();
        Model.User Find(long id);
    }
}
