using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParam : AccountParam
    {
        public UniversityDemo.Speciality Speciality { get; set; }

        public UniversityDemo.StudentStatus Status { get; set; }
    }
}
