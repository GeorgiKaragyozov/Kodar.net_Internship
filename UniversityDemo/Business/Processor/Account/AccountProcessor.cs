using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Processor.Account
{
    public class AccountProcessor: IAccountProcessor
    {
        public AccountDao Dao { get; set; }

        public AccountParamConverter ParamConverter { get; set; }

        public AccountResultConverter ResultConverter { get; set; }

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

            foreach (var item in entity)
            {
                result.Add(ResultConverter.Convert(item));
            }

            return result;
        }

        public void Delete(long id)
        {
            Dao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            Dao.Delete(idList);
        }

        public AccountResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountResult> Find()
        {
            List<UniversityDemo.Account> entity = Dao.Find();

            List<AccountResult> results = new List<AccountResult>();

            foreach (var item in entity)
            {
                results.Add(ResultConverter.Convert(item));
            }

            return results;
        }

        public void Update(long id, AccountParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
