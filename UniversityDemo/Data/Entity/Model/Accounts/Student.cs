using Newtonsoft.Json;
using System;
using UniversityDemo.Enums;

namespace UniversityDemo
{
    public class Student: Account
    {
        [JsonIgnore]
        public Speciality Speciality { get; set; }

        [JsonIgnore]
        public StudentStatus StudentStatus { get; set; }
    }
}
