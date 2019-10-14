using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public interface ITeacherStatusParamConverter
    {
        Model.Accounts.TeacherStatus Convert(AccountParam param);
    }
}
