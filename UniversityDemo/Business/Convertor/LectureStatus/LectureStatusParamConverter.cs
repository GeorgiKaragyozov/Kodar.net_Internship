using System;
using UniversityDemo.Business.Convertor.Account;
using UniversityDemo.Data.Entity.Model.Status;
using UniversityDemo.DataAccess.DataAccessObject.LectureStatus;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusParamConverter: ILectureStatusParamConverter
    {
        public LectureStatusDao LectureStatusDao { get; set; }

        public Data.Entity.Model.Status.LectureStatus Convert(AccountParam param)
        {
            throw new NotImplementedException();
        }
    }
}
