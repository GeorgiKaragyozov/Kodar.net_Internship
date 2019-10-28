using System;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusResultConverter : ILectureStatusResultConverter
    {
        public LectureStatusResult Convert(Data.Entity.Model.Status.LectureStatus param)
        {
            LectureStatusResult result = new LectureStatusResult()
            {
                Id = param.Id,
                Code = param.Code,
                Name = param.Name,
                Description = param.Description,
            };

            return result;
        }
    }
}
