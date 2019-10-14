using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.FacultyStatus
{
    public interface IFacultyStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.FacultyStatus param);
    }
}
