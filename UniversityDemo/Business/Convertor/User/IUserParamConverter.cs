using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.User
{
    public interface IUserParamConverter
    {
        UniversityDemo.User Convert(AccountParam param);
    }
}
