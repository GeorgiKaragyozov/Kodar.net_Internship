using System;
using UniversityDemo.Business.Processor.TeacherStatus;

namespace UniversityDemo.Presentation.Service.TeacherStatus
{
    public class TeacherStatusService: ITeacherStatusService
    {
        public TeacherStatusProcessor Processor { get; set; }
    }
}
