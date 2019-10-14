using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public interface ILectureStatusParamConverter
    {
        Data.Entity.Model.Status.LectureStatus Convert(AccountParam param);
    }
}
