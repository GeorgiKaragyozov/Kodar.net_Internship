using System;
using System.Collections.Generic;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public interface IAccountDao
    {
        Model.Account Save(Model.Account entity);
        List<Model.Account> Save(List<Model.Account> entity);

        Model.Account Update(Model.Account entity);
        List<Model.Account> Update(List<Model.Account> entity);

        void Delete(long id);
        void Delete(Model.Account entity);
        void Delete(List<long> idList);

        List<Model.Account> Find();
        Model.Account Find(long id);
        List<Model.Account> Find(string field, string value);
        Model.Account Find(string name);
        List<Model.Account> FindByCode(string code);
        List<Model.Account> FindByDescription(string description);
    }
}
