using System;

namespace UniversityDemo.Business.Convertor.Departament
{
    public class DepartamentResult : BaseResultNamed
    {
        public UniversityDemo.Teacher Teacher { get; set; }

        public UniversityDemo.Speciality Speciality { get; set; }

        public UniversityDemo.DepartamentStatus Status { get; set; }
    }
}
