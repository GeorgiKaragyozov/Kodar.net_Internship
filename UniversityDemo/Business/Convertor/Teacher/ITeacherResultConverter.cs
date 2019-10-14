using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public interface ITeacherResultConverter
    {
        AccountResult Convert(UniversityDemo.Teacher param);
    }
}
