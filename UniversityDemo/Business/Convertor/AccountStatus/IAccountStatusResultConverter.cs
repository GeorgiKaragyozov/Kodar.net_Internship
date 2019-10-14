using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.AccountStatus
{
    public interface IAccountStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.AccountStatus param);
    }
}
