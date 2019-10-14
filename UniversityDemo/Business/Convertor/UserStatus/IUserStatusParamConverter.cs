using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public interface IUserStatusParamConverter
    {
        UniversityDemo.UserStatus Convert(AccountParam param);
    }
}
