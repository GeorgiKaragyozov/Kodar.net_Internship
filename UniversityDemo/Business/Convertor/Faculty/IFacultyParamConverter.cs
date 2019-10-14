using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public interface IFacultyParamConverter
    {
        UniversityDemo.Faculty Convert(AccountParam param);
    }
}
