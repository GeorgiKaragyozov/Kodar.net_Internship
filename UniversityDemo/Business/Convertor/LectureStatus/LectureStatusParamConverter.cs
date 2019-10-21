using System;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusParamConverter: ILectureStatusParamConverter
    {
        public ILectureStatusDao Dao { get; set; }

        public LectureStatusParamConverter(ILectureStatusDao dao)
        {
            this.Dao = dao;
        }

        public Data.Entity.Model.Status.LectureStatus Convert(LectureStatusParam param)
        {
            throw new NotImplementedException();
        }
    }
}
