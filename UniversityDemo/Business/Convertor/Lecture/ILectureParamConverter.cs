using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public interface ILectureParamConverter
    {
        Model.Lecture Convert(AccountParam param);
    }
}
