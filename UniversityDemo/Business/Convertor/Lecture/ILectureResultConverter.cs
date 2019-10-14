using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public interface ILectureResultConverter
    {
        AccountResult Convert(Model.Lecture param);
    }
}
