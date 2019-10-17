using System;
using System.Collections.Generic;

namespace UniversityDemo
{
    public class Departament : NamedPersistent
    {
        public Teacher Teacher { get; set; }

        public Speciality Speciality { get; set; }

        public DepartamentStatus Status { get; set; }
    }
}
