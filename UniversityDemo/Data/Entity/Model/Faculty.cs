    using System;
using System.Collections.Generic;

namespace UniversityDemo
{
    public class Faculty: NamedPersistent
    {
        public Departament Departament { get; set; }

        public FacultyStatus Status { get; set; }
    }
}
