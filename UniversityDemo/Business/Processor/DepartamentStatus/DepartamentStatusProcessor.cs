using System;
using UniversityDemo.Business.Convertor.DepartamentStatus;
using UniversityDemo.DataAccess.DataAccessObject.DepartamentStatus;

namespace UniversityDemo.Business.Processor.DepartamentStatus
{
    public class DepartamentStatusProcessor: IDepartamentStatusProcessor
    {
        public DepartamentStatusDao DepartamentStatusDao { get; set; }

        public DepartamentStatusParamConverter DepartamentStatusParamConverter { get; set; }

        public DepartamentStatusResultConverter DepartamentStatusResultConverter { get; set; }
    }
}
