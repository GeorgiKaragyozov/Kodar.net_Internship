using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public interface ITeacherParamConverter
    {
        UniversityDemo.Teacher Convert(AccountParam param);
    }
}
