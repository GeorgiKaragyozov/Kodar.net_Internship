using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.User
{
    public interface IUserResultConverter
    {
        AccountResult Convert(UniversityDemo.User param);
    }
}
