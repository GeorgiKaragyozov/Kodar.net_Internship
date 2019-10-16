using System;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusParamConverter: ILectureStatusParamConverter
    {
        public LectureStatusDao Dao { get; set; }

        public Data.Entity.Model.Status.LectureStatus Convert(LectureStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
