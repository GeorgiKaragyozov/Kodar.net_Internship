using System;
using UniversityDemo.Model.Accounts;

namespace UniversityDemo
{
    public class Teacher: Account
    {
        public TeacherStatus Status { get; set; }
    }
}
