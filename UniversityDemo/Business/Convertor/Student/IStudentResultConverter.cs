using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Student
{
    public interface IStudentResultConverter
    {
        AccountResult Convert(UniversityDemo.Student param);
    }
}
