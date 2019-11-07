using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.LectureStatus
{
    public interface ILectureStatusResultConverter
    {
        LectureStatusResult Convert(Model.LectureStatus param);
    }
}
