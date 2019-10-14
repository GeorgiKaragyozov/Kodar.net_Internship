using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public interface IAccountStatusParamConverter
    {
        UniversityDemo.AccountStatus Convert(AccountParam param);
    }
}
