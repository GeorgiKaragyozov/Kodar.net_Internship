using System;
using UniversityDemo.Business.Convertor.Account;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentResult : AccountParam 
    {
        public UniversityDemo.Speciality Speciality { get; set; }

        public UniversityDemo.StudentStatus Status { get; set; }
    }
}
