using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public interface ILectureResultConverter
    {
        LectureResult Convert(Model.Lecture param);
    }
}
