using System;

namespace UniversityDemo.Business.Convertor.Student
{
    public class StudentParam : BaseParamNamed
    {
        public UniversityDemo.Speciality Speciality { get; set; }

        public UniversityDemo.StudentStatus Status { get; set; }
    }
}
