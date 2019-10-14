using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Discipline
{
    public interface IDisciplineParamConverter
    {
        UniversityDemo.Discipline Convert(AccountParam param);
    }
}
