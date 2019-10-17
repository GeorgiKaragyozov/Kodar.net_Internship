using System;

namespace UniversityDemo.Business.Convertor.Faculty
{
    public class FacultyParam : BaseParamNamed
    {
        public UniversityDemo.Departament Departament { get; set; }

        public UniversityDemo.FacultyStatus Status { get; set; }
    }
}
