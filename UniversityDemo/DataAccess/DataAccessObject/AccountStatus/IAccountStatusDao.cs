using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.AccountStatus
{
    public interface IAccountStatusDao
    {
        Model.AccountStatus Save(Model.AccountStatus entity);
        List<Model.AccountStatus> Save(List<Model.AccountStatus> entity);

        Model.AccountStatus Update(Model.AccountStatus entity);
        List<Model.AccountStatus> Update(List<Model.AccountStatus> entity);

        void Delete(long id);
        void Delete(Model.AccountStatus entity);
        void Delete(List<long> idList);

        List<Model.AccountStatus> Find();
        Model.AccountStatus Find(long id);
        Model.AccountStatus Find(string name);
    }
}
