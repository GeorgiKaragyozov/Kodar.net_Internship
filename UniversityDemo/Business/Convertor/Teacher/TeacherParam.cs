using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Teacher
{
    public class TeacherParam : AccountParam
    {
        public Model.Accounts.TeacherStatus Status { get; set; }
    }
}
