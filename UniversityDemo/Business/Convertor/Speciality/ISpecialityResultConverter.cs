using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Speciality
{
    public interface ISpecialityResultConverter
    {
        AccountResult Convert(UniversityDemo.Speciality param);
    }
}
