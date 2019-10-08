using System;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusParamConverter: ILectureStatusParamConverter
    {
        public LectureStatusDao LectureStatusDao { get; set; }
    }
}
