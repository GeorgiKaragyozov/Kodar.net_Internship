using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherResult : AccountParam
    {
        public Model.Accounts.TeacherStatus Status { get; set; }
    }
}
