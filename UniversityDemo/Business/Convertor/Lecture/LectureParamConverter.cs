using System;
using UniversityDemo.DataAccess.DataAccessObject.Lecture;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public class LectureParamConverter: ILectureParamConverter
    {
        public LectureDao LectureDao { get; set; }
    }
}
