using System;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParamConverter: IAccountParamConverter
    {
        public AccountDao AccountDao { get; set; }
    }
}
