using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.StudentStatus
{
    public interface IStudentStatusParamConverter
    {
        UniversityDemo.StudentStatus Convert(AccountParam param);
    }
}
