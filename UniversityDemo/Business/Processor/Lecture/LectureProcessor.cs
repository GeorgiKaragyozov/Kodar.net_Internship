using System;
using UniversityDemo.Business.Convertor.Lecture;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Processor.Lecture
{
    public class LectureProcessor: ILectureProcessor
    {
        public LectureDao LectureDao { get; set; }

        public LectureParamConverter LectureParamConverter { get; set; }

        public LectureResultConverter LectureResultConverter { get; set; }       
    }
}
