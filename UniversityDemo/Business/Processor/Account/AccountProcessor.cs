using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Processor.Account
{
    public class AccountProcessor: IAccountProcessor
    {
        public IAccountDao Dao { get; set; }

        public IAccountParamConverter ParamConverter { get; set; }

        public IAccountResultConverter ResultConverter { get; set; }

        public AccountProcessor(IAccountDao dao, IAccountParamConverter paramConverter, 
            IAccountResultConverter resultConverter)
        {
            this.Dao = dao;
            this.ParamConverter = paramConverter;
            this.ResultConverter = resultConverter;
        }

        public AccountResult Create(AccountParam param)
        {
            UniversityDemo.Account entity = ParamConverter.Convert(param);

            entity = Dao.Save(entity);

            return ResultConverter.Convert(entity);
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            List<UniversityDemo.Account> entity = new List<UniversityDemo.Account>();

            foreach (var item in param)
            {
                entity.Add(ParamConverter.Convert(item));
            }

            Dao.Save(entity);

            List<AccountResult> result = new List<AccountResult>();

            entity.ForEach(ent => result.Add(ResultConverter.Convert(ent)));

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)   
        {
            List<UniversityDemo.Account> entity = new List<UniversityDemo.Account>();

            foreach (var item in idList)
            {
                entity.Add(Dao.Find(item));
            }

            Dao.Delete(idList);
        }

        public AccountResult Find(long id)
        {
            UniversityDemo.Account entity = Dao.Find(id);
            AccountResult result = ResultConverter.Convert(entity);

            return result;
        }

        public List<AccountResult> Find()
        {
            List<UniversityDemo.Account> entity = Dao.Find();

            List<AccountResult> result = new List<AccountResult>();

            foreach (var item in entity)
            {
                result.Add(ResultConverter.Convert(item));
            }

            return result;
        }

        public void Update(long id, AccountParam param)
        {
            UniversityDemo.Account entity = Dao.Find(id);
            entity = ParamConverter.Convert(param);

            Dao.Update(entity);
        }

        public void Update(List<AccountParam> param)
        {
            List<UniversityDemo.Account> entity = new List<UniversityDemo.Account>();

            foreach (var item in param)
            {
                entity.Add(ParamConverter.Convert(item));
            }

            Dao.Update(entity);
        }
    }
}
