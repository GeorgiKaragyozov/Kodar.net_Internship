using System;
using UniversityDemo.Business.Convertor.LectureStatus;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Processor.LectureStatus
{
    public class LectureStatusProcessor: ILectureStatusProcessor
    {
         public LectureStatusDao LectureStatusDao { get; set; }

        public LectureStatusParamConverter LectureStatusParamConverter { get; set; }

        public LectureStatusResultConverter LectureStatusResultConverter { get; set; }       
    }
}
