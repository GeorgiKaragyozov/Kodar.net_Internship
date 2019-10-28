using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.AccountStatus;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Processor.AccountStatus
{
    public class AccountStatusProcessor: IAccountStatusProcessor
    {
        public IAccountStatusDao Dao = new AccountStatusDao();

        public IAccountStatusParamConverter ParamConverter = new AccountStatusParamConverter();

        public IAccountStatusResultConverter ResultConverter = new AccountStatusResultConverter();

        //public AccountStatusProcessor(IAccountStatusDao dao, IAccountStatusParamConverter paramConverter,
        //    IAccountStatusResultConverter resultConverter)
        //{
        //    this.Dao = dao;
        //    this.ParamConverter = paramConverter;
        //    this.ResultConverter = resultConverter;
        //}

        public AccountStatusResult Create(AccountStatusParam param)
        {
            UniversityDemo.AccountStatus entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
        {
            List<UniversityDemo.AccountStatus> entities = new List<UniversityDemo.AccountStatus>();

            foreach (var item in param)
            {
                entities.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entities);

            List<AccountStatusResult> results = new List<AccountStatusResult>();

            entities.ForEach(ent => results.Add(ResultConverter.Convert(ent)));

            return results;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<UniversityDemo.AccountStatus> entities = new List<UniversityDemo.AccountStatus>();

            foreach (var item in idList)
            {
                entities.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public AccountStatusResult Find(long id)
        {
            UniversityDemo.AccountStatus entity = Dao.Find(id);
            AccountStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public AccountStatusResult Find(string name)
        {
            UniversityDemo.AccountStatus entity = Dao.Find(name);
            AccountStatusResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<AccountStatusResult> Find()
        {
            List<UniversityDemo.AccountStatus> accounts = Dao.Find();

            List<AccountStatusResult> result = new List<AccountStatusResult>();

            foreach (var item in accounts)
            {
                result.Add(ResultConverter.Convert(item));
            }

            return result;
        }

        public void Update(long id, AccountStatusParam param)
        {
            UniversityDemo.AccountStatus oldEntity = Dao.Find(id);

            if (oldEntity != null)
            {
                Dao.Delete(oldEntity);
                Dao.Update(ParamConverter.Convert(param));
            }
            else
            {
                Console.WriteLine($"No object with Id = {id}  was found");
            }
        }

        public void Update(List<AccountStatusParam> param)
        {
            //List<UniversityDemo.AccountStatus> entities = new List<UniversityDemo.AccountStatus>();

            foreach (var item in param)
            {
                UniversityDemo.AccountStatus oldEntity = Dao.Find(item.Id);
                UniversityDemo.AccountStatus newEntity = ParamConverter.Convert(item);

                Dao.Update(newEntity);
            }
        }
    }
}
