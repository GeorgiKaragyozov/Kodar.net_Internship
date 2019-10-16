using System;
using UniversityDemo.DataAccess.DataAccessObject.Account;

namespace UniversityDemo.Business.Convertor.Account
{
    public class AccountParamConverter: IAccountParamConverter
    {
        public AccountDao Dao { get; set; }

        public UniversityDemo.Account Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
