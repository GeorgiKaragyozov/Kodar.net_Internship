using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public interface IStudentStatusResultConverter
    {
        AccountResult Convert(UniversityDemo.StudentStatus param);
    }
}
