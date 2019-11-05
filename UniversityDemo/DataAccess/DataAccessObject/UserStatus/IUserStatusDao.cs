using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.UserStatus
{
    public interface IUserStatusDao
    {
        Model.UserStatus Save(Model.UserStatus entity);
        List<Model.UserStatus> Save(List<Model.UserStatus> entity);

        Model.UserStatus Update(Model.UserStatus entity);
        List<Model.UserStatus> Update(List<Model.UserStatus> entity);

        void Delete(long id);
        void Delete(Model.UserStatus entity);
        void Delete(List<long> idList);

        List<Model.UserStatus> Find();
        Model.UserStatus Find(long id);
    }
}
