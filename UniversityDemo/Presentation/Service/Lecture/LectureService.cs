using System;
using UniversityDemo.Business.Processor.Lecture;

namespace UniversityDemo.Presentation.Service.Lecture
{
    public class LectureService: ILectureProcessor
    {
        public LectureProcessor Processor { get; set; }
    }
}
