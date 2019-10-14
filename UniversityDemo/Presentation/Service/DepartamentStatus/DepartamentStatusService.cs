using System;
using UniversityDemo.Business.Processor.DepartamentStatus;

namespace UniversityDemo.Presentation.Service.DepartamentStatus
{
    public class DepartamentStatusService: IDepartamentStatusService
    {
        public DepartamentStatusProcessor Processor { get; set; }
    }
}
