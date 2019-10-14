using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.SpecialityStatus
{
    public interface ISpecialityStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.SpecialityStatus param);
    }
}
