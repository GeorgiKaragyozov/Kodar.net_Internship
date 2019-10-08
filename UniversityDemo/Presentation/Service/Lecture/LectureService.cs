using System;
using UniversityDemo.Business.Processor.Lecture;

namespace UniversityDemo.Presentation.Service.Lecture
{
    public class LectureService: IServiceProvider
    {
        public LectureProcessor LectureProcessor { get; set; }
    }
}
