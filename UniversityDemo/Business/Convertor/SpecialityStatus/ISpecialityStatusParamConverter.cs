using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public interface ISpecialityStatusParamConverter
    {
        UniversityDemo.SpecialityStatus Convert(AccountParam param);
    }
}
