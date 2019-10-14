using System;
using UniversityDemo.Business.Processor.SpecialityStatus;

namespace UniversityDemo.Presentation.Service.SpecialityStatus
{
    public class SpecialityStatusService: ISpecialityStatusService
    {
        public SpecialityStatusProcessor Processor { get; set; }
    }
}
