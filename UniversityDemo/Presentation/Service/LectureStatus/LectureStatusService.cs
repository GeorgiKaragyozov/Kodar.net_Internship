using System;
using UniversityDemo.Business.Processor.LectureStatus;

namespace UniversityDemo.Presentation.Service.LectureStatus
{
    public class LectureStatusService: ILectureStatusService
    {
        public LectureStatusProcessor Processor { get; set; }
    }
}
