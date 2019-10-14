using System;
using UniversityDemo.Business.Processor.Discipline;

namespace UniversityDemo.Presentation.Service.Discipline
{
    public class DisciplineService: IDisciplineService
    {
        public DisciplineProcessor Processor { get; set; }
    }
}
