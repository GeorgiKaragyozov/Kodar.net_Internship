using System;
using UniversityDemo.Business.Convertor.Discipline;
using UniversityDemo.DataAccess.DataAccessObject.Discipline;

namespace UniversityDemo.Business.Processor.Discipline
{
    public class DisciplineProcessor: IDisciplineProcessor
    {
        public DisciplineDao DisciplineDao { get; set; }

        public DisciplineParamConverter DisciplineParamConverter { get; set; }

        public DisciplineResultConverter DisciplineResultConverter { get; set; }
    }
}
