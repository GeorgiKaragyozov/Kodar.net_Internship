using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.TeacherStatus
{
    public interface ITeacherStatusResultConverter
    {
        AccountResult Convert(Model.Accounts.TeacherStatus param);
    }
}
