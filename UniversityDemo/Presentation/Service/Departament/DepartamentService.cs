using System;
using UniversityDemo.Business.Processor.Departament;

namespace UniversityDemo.Presentation.Service.Departament
{
    public class DepartamentService: IDepartamentService
    {
        public DepartamentProcessor DepartamentProcessor { get; set; }
    }
}
