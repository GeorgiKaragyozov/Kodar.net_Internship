using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter: IAccountStatusParamConverter
    {
        public AccountStatusDao AccountStatusDao { get; set; }

        public UniversityDemo.AccountStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
