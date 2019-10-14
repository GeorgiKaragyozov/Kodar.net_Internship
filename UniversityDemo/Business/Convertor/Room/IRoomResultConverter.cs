using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Room
{
    public interface IRoomResultConverter
    {
        AccountResult Convert(UniversityDemo.Room param);
    }
}
