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
            throw new NotImplementedException();
        }

        public List<AccountResult> Create(List<AccountParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public AccountResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountResult> Find()
        {
            throw new NotImplementedException();
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
