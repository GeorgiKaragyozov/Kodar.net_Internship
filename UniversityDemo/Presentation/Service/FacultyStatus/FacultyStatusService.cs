using System;
using UniversityDemo.Business.Processor.FacultyStatus;

namespace UniversityDemo.Presentation.Service.FacultyStatus
{
    public class FacultyStatusService: IFacultyStatusService
    {
        public FacultyStatusProcessor Processor { get; set; }
    }
}
