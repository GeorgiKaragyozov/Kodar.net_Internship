using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Room
{
    public interface IRoomParamConverter
    {
        UniversityDemo.Room Convert(AccountParam param);
    }
}
