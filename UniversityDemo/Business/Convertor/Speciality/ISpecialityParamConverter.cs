using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public interface ISpecialityParamConverter
    {
        UniversityDemo.Speciality Convert(AccountParam param);
    }
}
