using System;
using UniversityDemo.Enums;

namespace UniversityDemo
{
    public class Student: Account
    {
        public Speciality Speciality { get; set; }

        public StudentStatus StudentStatus { get; set; }
    }
}
