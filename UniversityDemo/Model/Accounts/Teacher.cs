using System;
using UniversityDemo.Enums;
using UniversityDemo.Model.Accounts;

namespace UniversityDemo
{
    public class Teacher: Account
    {
        public TeacherStatus TeacherStatus { get; set; }
    }
}
