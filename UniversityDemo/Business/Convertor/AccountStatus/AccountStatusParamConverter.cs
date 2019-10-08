using System;
using UniversityDemo.DataAccess.DataAccessObject.AccountStatus;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public class AccountStatusParamConverter: IAccountStatusParamConverter
    {
        public AccountStatusDao AccountStatusDao { get; set; }
    }
}
