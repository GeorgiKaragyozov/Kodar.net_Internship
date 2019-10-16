using System;
using System.Collections.Generic;
using UniversityDemo.Business.Convertor.AccountStatus;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Processor.AccountStatus
{
    public class AccountStatusProcessor: IAccountStatusProcessor
    {
        public AccountStatusDao Dao { get; set; }

        public AccountStatusParamConverter ParamConverter { get; set; }

        public AccountStatusResultConverter ResultConverter { get; set; }

        public AccountStatusResult Create(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public List<AccountStatusResult> Create(List<AccountStatusParam> param)
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

        public AccountStatusResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<AccountStatusResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, AccountStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<AccountStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
