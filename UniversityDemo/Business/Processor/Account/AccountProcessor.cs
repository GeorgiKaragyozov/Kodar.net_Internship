using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Processor.Account
{
    public class AccountProcessor: IAccountProcessor
    {
        public IAccountDao Dao = new AccountDao();

        public IAccountParamConverter ParamConverter = new AccountParamConverter();

        public IAccountResultConverter ResultConverter = new AccountResultConverter();

        //public AccountProcessor(IAccountDao dao, IAccountParamConverter paramConverter,
        //    IAccountResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public AccountResult Create(AccountParam param)
        {
            Model.Account entity = ParamConverter.Convert(param, null);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            List<Model.Account> entities = new List<Model.Account>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item, null));
            }

            Dao.Save(entities);

            List<AccountResult> result = new List<AccountResult>();

            entities.ForEach(ent => result.Add(ResultConverter.Convert(ent)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)   
        {
            List<Model.Account> entities = new List<Model.Account>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            foreach (var item in idList)
            {
                Dao.Delete(item);
            }          
        }

        public AccountResult Find(long id)
        {
            Model.Account entity = Dao.Find(id);
            AccountResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<AccountResult> Find(string field, string value)
        {
            List<Model.Account> accounts = Dao.Find(field, value);
            List<AccountResult> results = new List<AccountResult>();

            foreach (var item in accounts)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public AccountResult Find(string name)
        {
            Model.Account entity = Dao.Find(name);
            AccountResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<AccountResult> Find()
        {
            List<Model.Account> entities = Dao.Find();

            List<AccountResult> results = new List<AccountResult>();

            foreach (var item in entities)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public List<AccountResult> FindByCode(string code)
        {
            List<AccountResult> results = new List<AccountResult>();

            Dao.FindByCode(code.ToLower())
                .ForEach(ac => results.Add(ResultConverter.Convert(ac)));

            return results;
        }

        public List<AccountResult> FindByDescription(string description)
        {
            List<AccountResult> results = new List<AccountResult>();

            Dao.FindByDescription(description.ToLower())
                .ForEach(ac => results.Add(ResultConverter.Convert(ac)));

            return results;
        }

        public void Update(long id, AccountParam param)
        {
            Model.Account oldEntity = Dao.Find(id);

            if (oldEntity != null)
            {
                Dao.Delete(oldEntity);
                Dao.Update(ParamConverter.Convert(param, null));
            }
            else
            {
                Console.WriteLine($"No object with Id = {id}  was found");
            }
        }

        public void Update(List<AccountParam> param)
        {
            //List<UniversityDemo.Account> entities = new List<UniversityDemo.Account>();

            foreach (var item in param)
            {
                Model.Account oldEntity = Dao.Find(item.Id);
                Model.Account newEntity = ParamConverter.Convert(item, null);

                Dao.Update(newEntity);
            }          
        }
    }
}
