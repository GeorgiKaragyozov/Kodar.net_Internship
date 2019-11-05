using System;
using System.Collections.Generic;
using System.Linq;

namespace UniversityDemo.DataAccess.DataAccessObject.Account
{
    public class AccountDao : IAccountDao
    {
        public void Delete(long id)
        {
            Model.Account entity = Find(id);
            Delete(entity);
        }   

        public void Delete(Model.Account entity)
        {
            AccountStorage.Accounts.Remove(entity);
            AccountStorage.Dictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Model.Account> Find()
        {
            return AccountStorage.Accounts;
        }

        public Model.Account Find(long id)
        {
            return AccountStorage.Accounts
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public List<Model.Account> Find(string field, string value)
        {
            return AccountStorage.Accounts
                .Where(a => a.GetType().GetProperty(field).GetValue(a, null).ToString().Equals(value))
                .ToList();
        }

        public Model.Account Find(string name)
        {
            return AccountStorage.Accounts
                .Where(n => n.Name == name)
                .Single();
        }

        public List<Model.Account> FindByCode(string code)
        {
            return AccountStorage.Accounts
                .Where(n => n.Code.ToLower().Equals(code.ToLower()))
                .ToList();
        }

        public List<Model.Account> FindByDescription(string description)
        {
            return AccountStorage.Accounts
                .Where(n => n.Description.ToLower().Equals(description.ToLower()))
                .ToList();
        }

        public Model.Account Save(Model.Account entity)
        {
            AccountStorage.Accounts.Add(entity);
            AccountStorage.Dictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Model.Account> Save(List<Model.Account> entity)
        {
            entity.ForEach(ent => AccountStorage.Accounts.Add(ent));

            entity.ForEach(ent => AccountStorage.Dictionary.Add(ent.Id, ent));

            return entity;
        }

        public Model.Account Update(Model.Account entity)
        {
            Delete(entity.Id);
            Save(entity);

            return entity;
        }

        public List<Model.Account> Update(List<Model.Account> entity)
        {
            entity.ForEach(ent => Update(ent));
            
            return entity;
        }
    }
}
