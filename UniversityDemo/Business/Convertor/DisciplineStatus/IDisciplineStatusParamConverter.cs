using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.DisciplineStatus
{
    public interface IDisciplineStatusParamConverter
    {
        UniversityDemo.DisciplineStatus Convert(AccountParam param);
    }
}
