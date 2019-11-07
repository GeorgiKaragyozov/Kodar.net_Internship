using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public class LectureStatusResultConverter : ILectureStatusResultConverter
    {
        public LectureStatusResult Convert(Model.LectureStatus param)
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
