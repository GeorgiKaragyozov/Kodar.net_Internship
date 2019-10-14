using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public interface ILectureStatusResultConverter
    {
        AccountResult Convert(Data.Entity.Model.Status.LectureStatus param);
    }
}
