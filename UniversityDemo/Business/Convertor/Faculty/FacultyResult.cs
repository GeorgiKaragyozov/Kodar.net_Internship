using System;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyResult : BaseResultNamed
    {
        public UniversityDemo.Departament Departament { get; set; }

        public UniversityDemo.FacultyStatus Status { get; set; }
    }
}
