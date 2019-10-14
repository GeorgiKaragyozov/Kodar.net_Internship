using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.UserStatus
{
    public interface IUserStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.UserStatus param);
    }
}
