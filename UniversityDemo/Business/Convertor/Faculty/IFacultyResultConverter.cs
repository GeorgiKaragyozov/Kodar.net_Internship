using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public interface IFacultyResultConverter
    {
        AccountResult Convert(UniversityDemo.Faculty param);
    }
}
