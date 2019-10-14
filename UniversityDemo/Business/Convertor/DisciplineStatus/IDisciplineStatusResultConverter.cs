using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public interface IDisciplineStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.DisciplineStatus param);
    }
}
