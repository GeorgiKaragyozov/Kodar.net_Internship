using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Student
{
    public interface IStudentParamConverter
    {
        UniversityDemo.Student Convert(AccountParam param);
    }
}
