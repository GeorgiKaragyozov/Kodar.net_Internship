using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public interface ILectureStatusParamConverter
    {
        Model.LectureStatus Convert(LectureStatusParam param, Model.LectureStatus oldEntity);
    }
}
