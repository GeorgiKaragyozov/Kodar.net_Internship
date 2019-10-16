using System;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter: IAccountStatusParamConverter
    {
        public AccountStatusDao Dao { get; set; }

        public UniversityDemo.AccountStatus Convert(AccountStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
