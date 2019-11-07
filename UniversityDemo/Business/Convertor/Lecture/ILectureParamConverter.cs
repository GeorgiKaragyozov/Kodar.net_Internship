using UniversityDemo.Business.Convertor.Common;

namespace UniversityDemo.Business.Convertor.Lecture
{
    public interface ILectureParamConverter
    {
        Model.Lecture Convert(LectureParam param, Model.Lecture oldEntity);
    }
}
