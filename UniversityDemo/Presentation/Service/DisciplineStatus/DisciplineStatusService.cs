using System;
using UniversityDemo.Business.Processor.DisciplineStatus;

namespace UniversityDemo.Presentation.Service.DisciplineStatus
{
    public class DisciplineStatusService: IDisciplineStatusService
    {
        public DisciplineStatusProcessor Processor { get; set; }
    }
}
