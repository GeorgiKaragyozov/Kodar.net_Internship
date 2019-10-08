using System;
using UniversityDemo.Business.Convertor.DisciplineStatus;
using UniversityDemo.DataAccess.DataAccessObject.DisciplineStatus;

namespace UniversityDemo.Business.Processor.DisciplineStatus
{
    public class DisciplineStatusProcessor: IDisciplineStatusProcessor
    {
        public DisciplineStatusDao DisciplineStatusDao { get; set; }

        public DisciplineStatusParamConverter DisciplineStatusParamConverter { get; set; }

        public DisciplineStatusResultConverter DisciplineStatusResultConverter { get; set; }
    }
}
