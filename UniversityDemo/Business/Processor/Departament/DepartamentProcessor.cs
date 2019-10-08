using System;
using UniversityDemo.Business.Convertor.Departament;
using UniversityDemo.DataAccess.DataAccessObject.Departament;

namespace UniversityDemo.Business.Processor.Departament
{
    public class DepartamentProcessor: IDepartamentProcessor
    {
        public DepartamentDao DepartamentDao { get; set; }

        public DepartamentParamConverter DepartamentParamConverter { get; set; }

        public DepartamentResultConverter DepartamentResultConverter { get; set; }
    }
}
