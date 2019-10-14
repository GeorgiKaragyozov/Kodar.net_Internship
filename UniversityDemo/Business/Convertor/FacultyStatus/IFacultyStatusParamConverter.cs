using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public interface IFacultyStatusParamConverter
    {
        UniversityDemo.FacultyStatus Convert(AccountParam param);
    }
}
